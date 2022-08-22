import React, { Component } from 'react';
import authService from '../api-authorization/AuthorizeService';


export class Cart extends Component {
  static displayName = Cart.name;

  constructor(props) {
    super(props);
    this.state = {
      isAuthenticated: false,
      userName: null,
      products: [{Product: {Name: 'stol', Price: 19, }, Amount: 4}, {Product: {Name: 'bord', Price: 59, }, Amount: 1}], //TODO: make empty; this is only an example
      loadingProducts: true
    }; 
  }

  componentDidMount() {
    this._subscription = authService.subscribe(() => this.populateState()); 
    this.populateState();
  }

  async populateState() {
    const [isAuthenticated, user] = await Promise.all([authService.isAuthenticated(), authService.getUser()])
    this.setState({
        isAuthenticated,
        userName: user && user.name,
    });
    console.log(user);
  }

  //Renders the table with the products
   renderProductsTable(products) {

    return (
      <>
      <table className='table table-striped' aria-labelledby="tabelLabel">
        <thead>
          <tr>
            <th>Name</th>
            <th>Price </th>
            <th>Amount</th>
          </tr>
        </thead>
        <tbody>
          {products.map(item =>
            <tr key={item.Product.Name} >
              <td>{item.Product.Name}</td>
              <td>{item.Product.Price}</td>
              <td ><a style={{cursor: "pointer", color:"#0366d6"}} onClick={() => this.increment(item.Product.Name)}>+ </a> {item.Amount} <a style={{cursor: "pointer", color:"#0366d6"}} onClick={() => this.decrement(item.Product.Name)}> -</a></td>
            </tr>
          )}
        </tbody>
      </table>
        <p>Total price: {products.reduce((acc, item) => acc+ item.Amount * item.Product.Price, 0)} </p>
        <button onClick={() => {window.location.replace("./checkout");}} className='btn btn-primary'>Checkout</button>   
</>
    );
  }



  render() {
    const { isAuthenticated, userName } = this.state;
    let title = isAuthenticated ? <h1 id="tabelLabel" >{userName}'s Cart</h1> : <h1 id="tabelLabel" >My Cart</h1> 


    const {data} = this.props.dataFromParent ===undefined ? [] : this.props.dataFromParent  ; // get info from product frontend about products added to cart   (/sendToCart can send to cart)
    if(data !== undefined && data !== []) {
      this.getProductsExtendedIfon(data);
    }

    let productData = this.state.loadingProducts ?  <p><em>Empty Cart...</em></p> : Cart.renderProductsTable(this.state.products)

    return (
      <div>
        {title}
        {productData}

      </div>
    );
    
  }

  async getProductsExtendedIfon(data) { 
    if(data === null) {
      return
    }
    const requestOptions = {
      method: 'POST',
      headers: { 'Content-Type': 'application/json' },
      body: JSON.stringify({ id: data.ProductId })
      };
    fetch('/api/product/findproduct', requestOptions) 
        .then(response => response.json())
        .then(dataNew => this.setState({ products: dataNew.total, loadingProducts:false })); //save extended products in products TODO: add to list instead of replacing?
    console.log('updated Product info!');
   }





  //Change amount 
  increment = name => {
    const newProducts = this.state.products.map(product => {
      // Does not match, so return the counter without changing.
      if (product.Product.Name !== name) return product;
      // Else (means match) return a new counter but change only the value
      return { ...product, Amount: product.Amount + 1};
    });

    this.setState({products: newProducts});
  };

  
decrement = name => {
    const newProducts = this.state.products.map(product => {
      // Does not match, so return the counter without changing.
      if (product.Product.Name !== name) return product;
      // Else (means match) return a new counter but change only the value
      return { ...product, Amount: product.Amount - 1};
    });

    this.setState({products: newProducts});
  };


  
}

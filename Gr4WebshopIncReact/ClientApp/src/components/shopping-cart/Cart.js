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
        <button   onClick={() => {window.location.replace("./checkout");}} className='btn btn-primary'>Checkout</button>   
</>
    );
  }



  render() {
    const { isAuthenticated, userName } = this.state;
    let title = isAuthenticated ? <h1 id="tabelLabel" >{userName}'s Cart</h1> : <h1 id="tabelLabel" >My Cart</h1> 

    const {data} = this.props.location; // get info from product frontend about products added to cart   (/sendToCart can send to cart)
    console.log(data);
    if(data !== undefined) {
      this.getProductsExtendedIfon(data);
    }

    let productData = this.state.loadingProducts ?  <p><em>Empty Cart...</em></p> : Cart.renderProductsTable(this.state.products)

    //let  dataFromCart = this.props.location ? <p><em>Empty cart</em></p> : Cart.getProductsInfo(this.props.location);
    return (
      <div>
        {title}
        {productData}
        {/*this.renderProductsTable(this.state.products)      saved for testing purposes  */}

      </div>
    );
    
  }

  async getProductsExtendedIfon(data) { 

    //TODO: Send data to backend to load extended product info
    fetch('') 
        .then(response => response.json())
        .then(dataNew => this.setState({ products: dataNew.total, loadingProducts:false })); //save extended products in products
    console.log('updated Products');
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

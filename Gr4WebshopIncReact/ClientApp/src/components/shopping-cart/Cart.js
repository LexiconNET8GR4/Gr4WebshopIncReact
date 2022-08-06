import React, { Component } from 'react';


export class Cart extends Component {
  static displayName = Cart.name;

  constructor(props) {
    super(props);
    this.state = { products: [], loadingProducts: true }; //global variables
  }

  componentDidMount() { //When cart component is mounted(loaded) the get request gets sent
    this.populateCartData();
  }

  //Renders the table with the products
  static renderProductsTable(products) { 
    let totalPrice = 0
    return (
      <table className='table table-striped' aria-labelledby="tabelLabel">
        <thead>
        <p>My products</p>
          <tr>
            <th>Name</th>
            <th>Price </th>
            <th>Amount (pieces)</th>
            <th>In stock (pieces)</th>
          </tr>
        </thead>
        <tbody>
          {products.map(item =>
          //this.setState({totalPrice: totalPrice + product.price}),
            <tr key={item.Product.Name}>
              <td>{item.Product.CurrentPrice}</td>
              <td>{item.Amount}</td>
              <td>{item.Product.Stock }</td>
            </tr>
          )}
        </tbody>
        <p>Total price {totalPrice}</p>
        <a href='./checkout'>Checkout</a>   
      </table>

    );
  }

  render() {
    //if the get request isn't done, then 'Loading products' text is shown until the get request is completed.
      let products_contents = this.state.loadingProducts
      ? <p><em>Loading products...</em></p>
      : Cart.renderProductsTable(this.state.products);

    return (
      <div>
        <h1 id="tabelLabel" >My Cart</h1>
        <a href='./checkout'>Checkout</a>   

        {products_contents}
      </div>
    );
  }



  async populateCartData() {
    
    //fetch('./api/CheckoutController/getallcategories')
    fetch('/api/CheckoutController/getallcartproducts')
        .then(response => response.json())
        .then(data => this.setState({ products: data.total, loadingProducts: false }));

   
  }
}

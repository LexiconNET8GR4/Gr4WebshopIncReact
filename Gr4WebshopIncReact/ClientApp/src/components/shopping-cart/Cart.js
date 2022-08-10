import React, { Component } from 'react';
import { useNavigate } from "react-router-dom";


export class Cart extends Component {
  static displayName = Cart.name;

  constructor(props) {
    super(props);
    this.state = {
       products: [
          {Product: {Name: 'stol', Price: 19, }, Amount: 4},
          {Product: {Name: 'bord', Price: 59, }, Amount: 1}
      ],
     loadingProducts: false }; //global variables
  }

  componentDidMount() { //When cart component is mounted(loaded) the get request gets sent
    this.populateCartData(); //TODO: send productID to this method, populateCartData(productID)
  }

  
  //Renders the table with the products
  static renderProductsTable(products) {

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
            <tr key={item.Product.Name}>
              <td>{item.Product.Name}</td>
              <td>{item.Product.Price}</td>
              <td><a style={{cursor: "pointer", color:"#0366d6"}} onClick={() => this.changeAmount('increase')}>+ </a> {item.Amount} <a style={{cursor: "pointer", color:"#0366d6"}} onClick={() => this.changeAmount('decrease')}> -</a></td>
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
    //if the get request isn't done, then 'Loading products' text is shown until the get request is completed.
      let products_contents = this.state.loadingProducts
      ? <p><em>Loading products...</em></p>
      : Cart.renderProductsTable(this.state.products);

    return (
      <div>
        <h1 id="tabelLabel" >My Cart</h1>


        {products_contents}
      </div>
    );
  }



  async populateCartData(productId) {
    
    //TODO: get product(s) from backend
        fetch('/api/???Controller/' + productId)
        .then(response => response.json())
        .then(data => this.setState({ products: data, loadingProducts: false }));

   
  }

  async changeAmount(change) {
    console.log(change);
    //TODO: connect to backend
  }
}

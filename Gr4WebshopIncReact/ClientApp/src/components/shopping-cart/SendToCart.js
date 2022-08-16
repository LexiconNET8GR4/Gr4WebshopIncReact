import ReactDOM from 'react-dom'
import React, { Component } from 'react';
import {Link} from 'react-router-dom';

var data = [
    {ProductId: '', Amount: null}
]

export class SendToCart extends React.Component {
    storeProductId = event => {
        data[0].ProductId = event.target.value;
    }
    storeAmount = event => {
        data[0].Amount = event.target.value;
    }

    state = {
      /*products: [ {Product: {Name: 'stol', Price: 19, }, Amount: 4},
                  {Product: {Name: 'bord', Price: 59, }, Amount: 1}]*/
    };
  

      
    render() {
      return (
        <>
        <h1>Send to Cart</h1>
        <div>
            <label>ProduktId</label>
            <input type='text' placeholder='ProductId' onChange={this.storeProductId}/>
            <br></br>
            <label>amount</label>
            <input type='number' placeholder='Amount' onChange={this.storeAmount}/>

            <br></br>
            <Link to={{pathname: 'cart', data: data}}>Send data to Cart</Link>
        </div>
        </>
      );
    }
  }
  

import React, { Component } from 'react';
import { Formik } from 'formik';
import authService from '../api-authorization/AuthorizeService';

export class Checkout extends Component {
  static displayName = Checkout.name;

  constructor(props) {
    super(props);

    this.state = { 
        isAuthenticated: false,
        userName: null,
        CartProducts: [
          {Product: {Name: 'stol', Price: 19, }, Amount: 3}, 
          {Product: {Name: 'bord', Price: 59, }, Amount: 1}
        ],
        CheckOutItems: [] //TODO: enter productIds, quantitys to  list
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
   static renderCartTable(products) { 
    return (
      <>
      <table className='table table-striped' aria-labelledby="tabelLabel">
        <thead>
          <tr>
            <th>Name</th>
            <th>Price </th>
            <th>Amount </th>
          </tr>
        </thead>
        <tbody>
          {products.map(item =>
            //this.setState({totalPrice: totalPrice + item.Product.Price}),
            <tr key={item.Product.Name}>
              <td>{item.Product.Name}</td>
              <td>{item.Product.Price}</td>
              <td>{item.Amount}</td>
            </tr>,
            {totalPrice: 3}
          )}
        </tbody>
      </table>
      <hr/>
      <h6>Total price: {products.reduce((acc, item) => acc+ item.Amount * item.Product.Price, 0)} </h6>
      </>

    );
  }


  render() {
  const { isAuthenticated, userName } = this.state;
  const AnonymousCheckout = () => (
    <Formik initialValues={{ FirstName: '', LastName: '', Adress:'', PhoneNumber: '', Email:'',   Type:'',   Provider:'' }}
            handleSubmit={(values) => {
              const body = {
                FirstName: values.FirstName,
                LastName: values.LastName,
                Adress: values.Adress,
                PhoneNumber: values.PhoneNumber,
                Email: values.Email,
                Type: values.type,
                Provider: values.Provider,
                CheckOutItems: this.state.CheckOutItems //TODO: enter correct list
              };
               const options = {
                method: "POST",
                headers: {
                  "Content-Type": "application/json",
                  Accept: "application/json"
                },
                body: JSON.stringify(body)
                
              };
            }}
            onSubmit={(values) => {
              if(values.FirstName == '' || values.LastName == '' || values.Adress == '' || values.PhoneNumber == 0 || values.Email == '' || values.Type == '' || values.Provider == '' ) {
                 { document.getElementById('Error').style.display = 'block'}
              } 
              else {
                 { document.getElementById('Error').style.display = 'none'}
                 this.sendData(values );
              }
          }}
            >
        
        {({values, handleChange, handleSubmit, isSubmitting}) =>(
            <form onSubmit={handleSubmit} >
                <label htmlFor='FirstName' style={{display: "block"}}>First name</label>
                    <input type='text' name='FirstName' onChange={handleChange} value={values.FirstName}/>
                <label htmlFor='LastName' style={{display: "block"}}>Last name</label>
                    <input type='text' name='LastName' onChange={handleChange} value={values.LastName}/>
                <label htmlFor='Adress' style={{display: "block"}}>Adress</label>
                    <input type='text' name='Adress' onChange={handleChange} value={values.Adress}/>
                <label htmlFor='PhoneNumber' style={{display: "block"}}>Phone number</label>
                    <input type='number' name='PhoneNumber' onChange={handleChange} value={values.PhoneNumber}/>
                <label htmlFor='Email' style={{display: "block"}}>Email</label>
                    <input type='text' name='Email' onChange={handleChange} value={values.Email}/>
                <label htmlFor='Type' style={{display: "block"}}>Payment type</label>
                    <input type='text' name='Type' onChange={handleChange} value={values.Type}/>
                <label htmlFor='Provider' style={{display: "block"}}>Shipment provider</label>
                    <input type='text' name='Provider' onChange={handleChange} value={values.Provider}/>
                <button className="btn btn-primary" type='submit' style={{display: "block", marginTop: "30px"}} disabled={isSubmitting}>Place order</button>
            </form>
        )} 
    </Formik>
  );

  const AuthenticatedCheckout = () => (
    <Formik initialValues={{ FirstName: '', LastName: '', Adress:'', PhoneNumber: '', Email:'',   Type:'',   Provider:'' }}
            handleSubmit={(values) => {
              const body = {
                Adress: values.Adress,
                CustomerID: userName, //TODO: might be wrong ID?  
                Type: values.type,
                Provider: values.Provider,
                CheckOutItems: this.state.CheckOutItems //TODO: enter correct list

              };
              const options = {
                method: "POST",
                headers: {
                  "Content-Type": "application/json",
                  Accept: "application/json"
                },
                body: JSON.stringify(body)
                
              };
            }}
             onSubmit={(values) => {
                if(values.FirstName == '' || values.LastName == '' || values.Adress == '' || values.PhoneNumber == 0 || values.Email == '' || values.Type == '' || values.Provider == '' ) {
                   { document.getElementById('Error').style.display = 'block'}
                } 
                else {
                   { document.getElementById('Error').style.display = 'none'}
                   this.sendData(values);
                }

            }}
            >
        
        {({values, handleChange, handleSubmit, isSubmitting}) =>(
            <form onSubmit={handleSubmit} >
                <label htmlFor='FirstName' style={{display: "block"}}>First name</label>
                    <input type='text' name='FirstName' onChange={handleChange} value={values.FirstName}/>

                <label htmlFor='LastName' style={{display: "block"}}>Last name</label>
                    <input type='text' name='LastName' onChange={handleChange} value={values.LastName}/>
                <label htmlFor='Adress' style={{display: "block"}}>Adress</label>
                    <input type='text' name='Adress' onChange={handleChange} value={values.Adress}/>
                <label htmlFor='PhoneNumber' style={{display: "block"}}>Phone number</label>
                    <input type='number' name='PhoneNumber' onChange={handleChange} value={values.PhoneNumber}/>
                <label htmlFor='Email' style={{display: "block"}}>Email</label>
                    <input disabled="" type='text' name='Email' onChange={handleChange} value={userName}/>
                <label htmlFor='Type' style={{display: "block"}}>Payment type</label>
                    <input type='text' name='Type' onChange={handleChange} value={values.Type}/>
                <label htmlFor='Provider' style={{display: "block"}}>Shipment provider</label>
                    <input type='text' name='Provider' onChange={handleChange} value={values.Provider}/>

                <button className="btn btn-primary" type='submit' style={{display: "block", marginTop: "30px"}} disabled={isSubmitting}>Place order</button>
            </form>
        )} 
    </Formik>
  );


  let cart_contents = this.state.CartProducts.length == 0
  ? <p><em>Empty Cart...</em></p>
  : Checkout.renderCartTable(this.state.CartProducts);


  if(!isAuthenticated) {
    return (
      <div>
      <div className='row'>
        <div className='col-md-7'>
          <h1 id="tabelLabel" >Enter credentials</h1>
          <AnonymousCheckout/>
        </div>
        <div className='col-md-5'>
          <h3>Cart</h3>
          {cart_contents}

        </div>
      </div>
      <p id="Error">Please enter all details  </p>
    </div>);
    
  } else {
    return(
      <div>
        <div className='row'>
          <div className='col-md-7'>
            <h1 id="tabelLabel" >Enter credentials</h1>
            <AuthenticatedCheckout/>
          </div>
          <div className='col-md-5'>
            <h3>Cart</h3>
            {cart_contents}

          </div>
        </div>
        <p id="Error">Please enter all details  </p>
      </div>);
   }
  }

  async changeProductIdForProducts(checkoutItems) {
    //TODO: send to backend
    //save products in CartProducts
  }

  async sendData(values) {
    //send post with values
  }
}

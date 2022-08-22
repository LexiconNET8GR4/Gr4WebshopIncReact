import React, { Component } from 'react';
import { Formik } from 'formik';
import authService from '../api-authorization/AuthorizeService';
import './style.css';


export class Checkout extends Component {
  static displayName = Checkout.name;

  constructor(props) {
    super(props);

    this.state = { 
        isAuthenticated: false,
        userName: null,
        GUID:'',
        extendedUser: [],
        loadedExtendedUser: false,
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
        GUID: user.sub
    });
    this.getUserInfo();
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
    <Formik initialValues={{ FirstName: '', LastName: '', Adress:'', PhoneNumber: '', Email:'',   Provider:'' }}
            onSubmit={(values) => {
              if(values.FirstName === '' || values.LastName === '' || values.Adress === '' || values.PhoneNumber === '' || values.Email === ''  || values.Provider === '' ) {
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
                <label htmlFor='Provider' style={{display: "block"}}>Shipping Adress </label>
                    <input type='text' name='Provider' onChange={handleChange} value={values.Provider}/>
                <button className="btn btn-primary" type='submit' style={{display: "block", marginTop: "30px"}} disabled={isSubmitting}>Place order</button>
            </form>
        )} 
    </Formik>
  );

  let AuthenticatedCheckout  = () => (
    <Formik initialValues={{ FirstName:this.state.extendedUser.firstName  !== null ? this.state.extendedUser.firstName : '',
                             LastName: this.state.extendedUser.lastName   !== null ? this.state.extendedUser.lastName  : '', 
                             Adress:   this.state.extendedUser.adress     !== null ? this.state.extendedUser.adress    : '' ,
                             PhoneNumber: this.state.extendedUser.phoneNumber !== null ? this.state.extendedUser.phoneNumber : '',
                             Email:       this.state.extendedUser.email   !== null ? this.state.extendedUser.email     : '', 
                             Provider: '' }}
             onSubmit={(values) => {
                if(values.FirstName === '' || values.LastName === '' || values.Adress === '' || values.PhoneNumber === '' || values.Email === '' || values.Provider === '' ) {
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
                    <input disabled="" type='text' name='Email' onChange={handleChange} value={values.Email}/>
                <label htmlFor='Provider' style={{display: "block"}}>Shipping adress</label>
                    <input type='text' name='Provider' onChange={handleChange} value={values.Provider}/>

                <button className="btn btn-primary" type='submit' style={{display: "block", marginTop: "30px"}} disabled={isSubmitting}>Place order</button>
            </form>
        )} 
    </Formik>
  );

  let cart_contents = this.state.CartProducts.length === 0
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
    return (
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

  async getUserInfo() {
    await fetch("/api/checkout/getuserdata")
    .then(res => res.json())
    .then(
      (result) => {
        console.log(result)
        this.setState({
          extendedUser : result,
          loadedExtendedUser: true
          /*isLoaded: true,
          items: result.items*/
        });
      },
      // Note: it's important to handle errors here
      // instead of a catch() block so that we don't swallow
      // exceptions from actual bugs in components.
      (error) => {
        this.setState({/*
          isLoaded: true,*/
          error
        });
      }
    )
   
  }

  async sendData(values) {
    const requestOptions = {
      method: 'POST',
      headers: { 'Content-Type': 'application/json' },
      body: ''
  };

    if (!this.state.isAuthenticated) { //Anonymously:
      const body = {
        checkoutItems: 'Stol', //TODO: enter correct list
        customer: 
        { 
          Adress: values.Adress,
          Email: values.Email,
          FirstName: values.FirstName,
          LastName: values.LastName,
          PhoneNumber: values.PhoneNumber,
          },
        shippingAddress: values.Provider,
      };
      requestOptions.body = JSON.stringify( body );
      let response =  await fetch('/api/checkout/anonymous', requestOptions);
      console.log('response' + response.data);
    } 
    else { // Autheniticated: 
      const body = {
        checkoutItems: 'Stol', //TODO: enter correct list
        customerId : this.state.GUID,
        shippingAddress: values.Provider,
      };
      requestOptions.body = body ; //TODO: should it be JSON.stringify?

      console.log(requestOptions.body)


      let response =  await fetch('/api/checkout/registered', requestOptions);
      console.log('response: ' + response.data);
    }
  }

}

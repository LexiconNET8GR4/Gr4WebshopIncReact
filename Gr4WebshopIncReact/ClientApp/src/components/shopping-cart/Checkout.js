import React, { Component } from 'react';
import { Formik } from 'formik';

export class Checkout extends Component {
  static displayName = Checkout.name;

  constructor(props) {
    super(props);
    this.state = {  };
  }


  render() {
  const NewPerson = () => (
    <Formik initialValues={{ FirstName: '', LastName: '', Adress:'', PhoneNumber: 0, Email:'',   Type:'',   Provider:'' }}
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
                <label htmlFor='FirstName' style={{display: "block"}}>FirstName</label>
                    <input type='text' name='FirstName' onChange={handleChange} value={values.FirstName}/>
                <label htmlFor='LastName' style={{display: "block"}}>LastName</label>
                    <input type='text' name='LastName' onChange={handleChange} value={values.LastName}/>
                <label htmlFor='Adress' style={{display: "block"}}>Adress</label>
                    <input type='text' name='Adress' onChange={handleChange} value={values.Adress}/>
                <label htmlFor='PhoneNumber' style={{display: "block"}}>PhoneNumber</label>
                    <input type='number' name='PhoneNumber' onChange={handleChange} value={values.PhoneNumber}/>
                <label htmlFor='Email' style={{display: "block"}}>Email</label>
                    <input type='text' name='Email' onChange={handleChange} value={values.Email}/>
                <hr/>
                <label htmlFor='Type' style={{display: "block"}}>Payment Type</label>
                    <input type='text' name='Type' onChange={handleChange} value={values.Type}/>
                    <hr/>
                <label htmlFor='Provider' style={{display: "block"}}>Shipment Provider</label>
                    <input type='text' name='Provider' onChange={handleChange} value={values.Provider}/>
                <button type='submit' style={{display: "block", marginTop: "30px"}} disabled={isSubmitting}>Place order</button>
            </form>
        )} 
    </Formik>
  );

    return (
      <div>
        <h1 id="tabelLabel" >Enter credentials</h1>
        <NewPerson/>
        <p id="Error">Please enter all details  </p>
      </div>
    );
  }

  async sendData(values) {
    //send post with values
  }
}

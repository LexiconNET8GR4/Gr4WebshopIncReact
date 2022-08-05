import React, { Component } from 'react';
import { Formik } from 'formik';

export class ForgotPasswordPage extends Component {
  static displayName = ForgotPasswordPage.name;

  constructor(props) {
    super(props);
    this.state = {  };
  }


  render() {
  const NewForgotPassword = () => (
    <Formik initialValues={{ Email: '' }}
            onSubmit={(values) => {
                if(values.Email == '') {
                   { document.getElementById('Error').style.display = 'block'}
                } 
                else {
                   { document.getElementById('Error').style.display = 'none'}
                   this.sendData(values);
                }
            }}>
        {({values, handleChange, handleSubmit, isSubmitting}) =>(
            <form onSubmit={handleSubmit} >
                <label htmlFor='Email' style={{display: "block"}}>Email</label>
                    <input type='text' name='Email' onChange={handleChange} value={values.Email}/>
                
                <button type='submit' style={{display: "block", marginTop: "30px"}} disabled={isSubmitting}>Submit</button>
            </form>
        )} 
    </Formik>
  );

    return (
      <div>
        <h1 id="tabelLabel" >Forgot your password?</h1>
        <h4>Enter your email.</h4>
        <hr/>
        <NewForgotPassword/>
        <p id="Error">Please enter all details  </p>
      </div>
    );
  }

  async sendData(values) {
    //send post with values

    //after Post redirect
    window.location.replace("./forgotPasswordConfirmation");
  }
}

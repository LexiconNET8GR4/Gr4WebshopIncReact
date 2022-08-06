import React, { Component } from 'react';
import { Formik } from 'formik';

export class RegisterPage extends Component {
  static displayName = RegisterPage.name;

  constructor(props) {
    super(props);
    this.state = { confirmPassword:'' };
  }


  render() {
  const NewRegister = () => (
    <Formik initialValues={{ FirstName:'', LastName:'', Adress:'', Email:'', Password:''}}
            onSubmit={(values) => {
                if(values.Email == '' || values.Password == '') {
                   { document.getElementById('Error').style.display = 'block'}
                } 
                else if(values.Password != this.confirmPassword) {
                   { document.getElementById('Error').style.display = 'block'}
                   {document.getElementById("Error").innerHTML = "Passwords doesn't match";}
                }
                else {
                   { document.getElementById('Error').style.display = 'none'}
                   this.sendData(values);
                }
            }}>
        {({values, handleChange, handleSubmit, isSubmitting}) =>(
            <form onSubmit={handleSubmit} >
                <label htmlFor='FirstName' style={{display: "block"}}>First Name</label>
                    <input type='text' name='FirstName' onChange={handleChange} value={values.FirstName}/>
                <label htmlFor='LastName' style={{display: "block"}}>Last Name</label>
                    <input type='text' name='LastName' onChange={handleChange} value={values.LastName}/>
                <label htmlFor='Adress' style={{display: "block"}}>Adress</label>
                    <input type='text' name='Adress' onChange={handleChange} value={values.Adress}/>
                <label htmlFor='Email' style={{display: "block"}}>Email</label>
                    <input type='text' name='Email' onChange={handleChange} value={values.Email}/>
                <label htmlFor='Password' style={{display: "block"}}>Password</label>
                    <input type='password' name='Password' onChange={handleChange} value={values.Password}/>
                <label htmlFor='confirmPassword' style={{display: "block"}}>Confirm Password</label>
                    <input type='password' name='confirmPassword' onChange={handleChange} value={this.confirmPassword}/>

               
                <button class="btn btn-primary" type='submit' style={{display: "block", marginTop: "30px"}} disabled={isSubmitting}>Register</button>
            </form>
        )} 
    </Formik>
  );

    return (
      <div>
        <h1 id="tabelLabel" >Register</h1>
        <h4>Create a new account.</h4>
        <hr/>
        <NewRegister/>
        <p id="Error">Please enter all details  </p>
      </div>
    );
  }

  async sendData(values) {
    //send post with values
    
    //then redirect to homepage
    window.location.replace("./");

  }
}

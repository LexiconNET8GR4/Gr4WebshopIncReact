import React, { Component } from 'react';
import { Formik } from 'formik';

export class LoginPage extends Component {
  static displayName = LoginPage.name;

  constructor(props) {
    super(props);
    this.state = {  };
  }


  render() {
  const NewLogin = () => (
    <Formik initialValues={{ Email: '', Password: '', RememberMe: false }}
            onSubmit={(values) => {
                if(values.Email == '' || values.Password == '') {
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
                <label htmlFor='Password' style={{display: "block"}}>Password</label>
                    <input type='text' name='Password' onChange={handleChange} value={values.Password} style={{display: "block"}}/>
                <input type="checkbox" value="RememberMe" /> 
                    <label for="RememberMe"> Remember me?</label>
                
                <button class="btn btn-primary" type='submit' style={{display: "block", marginTop: "30px"}} disabled={isSubmitting}>Log in</button>
            </form>
        )} 
    </Formik>
  );

    return (
      <div>
        <h1 id="tabelLabel" >Log in</h1>
        <h4>Use an existing account to sign in.</h4>
        <hr/>
        <NewLogin/>
        <p id="Error">Please enter all details  </p>
        <a href='forgotPassword' style={{display: "block"}} >Forgot your password?</a>
        <a href='register'>Register as a new user</a>

      </div>
    );
  }

  async sendData(values) {
    //TODO: send post with values
  }
}

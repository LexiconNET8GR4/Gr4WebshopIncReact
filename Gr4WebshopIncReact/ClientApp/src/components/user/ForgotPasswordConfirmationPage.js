import React, { Component } from 'react';

export class ForgotPasswordConfirmationPage extends Component {
  static displayName = ForgotPasswordConfirmationPage.name;

  constructor(props) {
    super(props);
    this.state = {  };
  }


  render() {
    return (
      <div>
        <h1 id="tabelLabel" >Forgot password confirmation</h1>
        <p>Please check your email to reset your password.</p>
      </div>
    );
  }

}

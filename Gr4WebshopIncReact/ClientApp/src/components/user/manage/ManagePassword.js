import React, { Component } from 'react';
import { Formik } from 'formik';

export class ManagePassword extends Component {
  static displayName = ManagePassword.name;

  constructor(props) {
    super(props);
    this.state = { ConfirmedPassword: '' };
  }



render() {
const RenderManageTable = () => (
    <div className="row">
    <div className='col-md-3'>
        <ul className='nav nav-pills flex-column'>
            <li className='nav-item'>
                <a className='nav-link' href='/manage'>Profile</a>
            </li>
            <li className='nav-item'>
                <a  className='nav-link ' href='/manageEmail'>Email</a>
            </li>
            <li className='nav-item'>
                <a className='nav-link active' href='/managePassword'>Password</a>
            </li>            
            <li className='nav-item'>
                <a className='nav-link' href='/manageOrderHistory'>Order History</a>
            </li>
        </ul>
    </div>

    <div className='col-md-9'>
        <h4>Change  password</h4>
        <div className='row'>
            <div className='col-md-6'>
                <Formik initialValues={{ CurrentPassword: '', NewPassword:'' }}
                         onSubmit={(values) => {
                            if(values.NewPassword === '' || values.CurrentPassword === '' || this.ConfirmedPassword === '' ) {
                               { document.getElementById('Error').style.display = 'block'}
                            } 
                            else if (values.NewPassword !== this.ConfirmedPassword ) {
                               { document.getElementById('Error').style.display = 'block'}
                               { document.getElementById('Error').innerHTML = 'The passwords do not match.'}

                            }
                            else {
                               { document.getElementById('Error').style.display = 'none'}
                               this.sendData(values);
                            }
                        }}>
                    {({values, handleChange, handleSubmit, isSubmitting}) =>(
                    <form onSubmit={handleSubmit} >
                        <label htmlFor='CurrentPassword' style={{display: "block"}}>Current password</label>
                            <input className="form-control" type='password'  name='CurrentPassword' onChange={handleChange} value={values.CurrentPassword}/>
                        <label htmlFor='NewPassword' style={{display: "block"}}>New Password</label>
                            <input className="form-control" type='password'  name='NewPassword' onChange={handleChange} value={values.NewPassword}/>
                        <label htmlFor='ConfirmedPassword' style={{display: "block"}}>Confirm new password</label>
                            <input className="form-control" type='password'  name='ConfirmedPassword' onChange={handleChange} value={this.ConfirmedPassword}/>    
                        <p id="Error">The new password is not a valid password. </p>
                        
                        <button className="btn btn-primary" type='submit' style={{display: "block", marginTop: "30px"}} disabled={isSubmitting}>Save</button>
                    </form>
        )} 
                </Formik>
            </div>
        </div>
    </div>
</div>
);

    return (
      <div className='container'>
        <h2 id="tabelLabel" >Manage your account</h2>
        <h4>change your account settings</h4>
        <hr/>
        <RenderManageTable/>

      </div>
    );
  }

  async sendData(values) {
    //TODO: send post with values
  }
}

import React, { Component } from 'react';
import { Formik } from 'formik';

export class ManageEmail extends Component {
  static displayName = ManageEmail.name;

  constructor(props) {
    super(props);
    this.state = {  };
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
                <a  className='nav-link active' href='/manageEmail'>Email</a>
            </li>
            <li className='nav-item'>
                <a className='nav-link' href='/managePassword'>Password</a>
            </li>            
            <li className='nav-item'>
                <a className='nav-link' href='/manageOrderHistory'>Order History</a>
            </li>
        </ul>
    </div>

    <div className='col-md-9'>
        <h4>Manage Email</h4>
        <div className='row'>
            <div className='col-md-6'>
                <Formik initialValues={{ Email: '' }}
                         onSubmit={(values) => {
                            if(values.Email === '' || !values.Email.includes("@") || !values.Email.includes(".")) {
                               { document.getElementById('Error').style.display = 'block'}
                            } 
                            else {
                               { document.getElementById('Error').style.display = 'none'}
                               this.sendData(values);
                            }
                        }}>
                    {({values, handleChange, handleSubmit, isSubmitting}) =>(
                    <form onSubmit={handleSubmit} >
                        <label htmlFor='Email' style={{display: "block"}}>New Email</label>
                            <input className="form-control" type='email' id="Input_NewEmail" name='Email' onChange={handleChange} value={values.Email}/>
                        <p id="Error">The new email is not a valid email </p>
                        
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

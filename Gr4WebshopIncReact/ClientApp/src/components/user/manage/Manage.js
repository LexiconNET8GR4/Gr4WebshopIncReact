import React, { Component } from 'react';
import { Formik } from 'formik';

export class Manage extends Component {
  static displayName = Manage.name;

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
                <a className='nav-link active' href='/manage'>Profile</a>
            </li>
            <li className='nav-item'>
                <a  className='nav-link' href='/manageEmail'>Email</a>
            </li>
            <li className='nav-item'>
                <a className='nav-link' href='/managePassword'>Password</a>
            </li>            <li className='nav-item'>
                <a className='nav-link' href='/manageOrderHistory'>Order History</a>
            </li>
        </ul>
    </div>

    <div className='col-md-9'>
        <h4>Profile</h4>
        <div className='row'>
            <div className='col-md-6'>
                <Formik initialValues={{ PhoneNumber: '' }}
                         onSubmit={(values) => {
                            if(values.PhoneNumber === '') {
                               { document.getElementById('Error').style.display = 'block'}
                            } 
                            else {
                               { document.getElementById('Error').style.display = 'none'}
                               this.sendData(values);
                            }
                        }}>
                    {({values, handleChange, handleSubmit, isSubmitting}) =>(
                    <form onSubmit={handleSubmit} >
                        <label htmlFor='PhoneNumber' style={{display: "block"}}>Phone Number</label>
                            <input className="form-control" type='tel' data-val-phone="The Phone number field is not a valid phone number." id="Input_PhoneNumber" name='PhoneNumber' onChange={handleChange} value={values.PhoneNumber}/>
                        <p id="Error">The Phone number field is not a valid phone number  </p>
                        
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

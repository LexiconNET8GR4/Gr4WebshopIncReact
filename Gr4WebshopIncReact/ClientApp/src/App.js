import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { FetchData } from './components/FetchData';
import { Counter } from './components/Counter';
import AuthorizeRoute from './components/api-authorization/AuthorizeRoute';
import ApiAuthorizationRoutes from './components/api-authorization/ApiAuthorizationRoutes';
import { ApplicationPaths } from './components/api-authorization/ApiAuthorizationConstants';
import { Cart }       from './components/shopping-cart/Cart';
import { Checkout }   from './components/shopping-cart/Checkout';
import { LoginPage }  from './components/user/LoginPage'; 
import { ForgotPasswordPage } from './components/user/ForgotPasswordPage'
import { ForgotPasswordConfirmationPage } from './components/user/ForgotPasswordConfirmationPage';
import { RegisterPage } from './components/user/RegisterPage';
import { Manage } from './components/user/manage/Manage';
import { ManageEmail } from './components/user/manage/ManageEmail';
import { ManagePassword } from './components/user/manage/ManagePassword';
import { ManageOrderHistory } from './components/user/manage/ManageOrderHistory';


import './custom.css';

export default class App extends Component {
  static displayName = App.name;

  render () {
    return (
      <Layout>
        <Route exact path='/' component={Home} />
        <Route path='/counter' component={Counter} />
        <AuthorizeRoute path='/fetch-data' component={FetchData} />
        <Route path={ApplicationPaths.ApiAuthorizationPrefix} component={ApiAuthorizationRoutes} />
        <AuthorizeRoute path='/cart' component={Cart} />
        <AuthorizeRoute path='/checkout' component={Checkout} />
        <Route path='/login' component={LoginPage} />
        <Route path='/forgotPassword' component={ForgotPasswordPage} />
        <Route path='/forgotPasswordConfirmation' component={ForgotPasswordConfirmationPage} />
        <Route path='/register' component={RegisterPage} />
        <AuthorizeRoute path='/manage'   component={Manage} />
        <AuthorizeRoute path='/manageEmail'   component={ManageEmail} />
        <AuthorizeRoute path='/managePassword'   component={ManagePassword} />
        <AuthorizeRoute path='/manageOrderHistory'   component={ManageOrderHistory} />
        
      </Layout>
    );
  }
}

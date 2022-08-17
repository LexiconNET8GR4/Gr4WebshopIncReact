import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { NavMenu } from './components/NavMenu'; // temporarily kept in to allow admin access
import Home from './components/pages/home';
import Header from './components/core/header';
import NavBars from  './components/core/sub-header';
import Footer from './components/core/footer';
import Products from './components/pages/products';
import Category from './components/pages/category';
import Landing from './components/landing';

import AuthorizeRoute from './components/api-authorization/AuthorizeRoute';
import ApiAuthorizationRoutes from './components/api-authorization/ApiAuthorizationRoutes';
import { ApplicationPaths } from './components/api-authorization/ApiAuthorizationConstants';
import CategoryView from './components/pages/detailCategory';

import './App.css'
import './custom.css'
import { LoginMenu } from './components/api-authorization/LoginMenu';

export default class App extends Component {
  static displayName = App.name;

    render() {
        return (
            <>
                <Route path={ApplicationPaths.ApiAuthorizationPrefix} component={ApiAuthorizationRoutes} />
                <NavMenu />
                <Header />
                <NavBars />
                 <Route path="/" component={Landing} />
                <Route path="/products" component={Products} />
                <Route path="/detail/:category" component={CategoryView} />
                <Footer />
            </>

            //--------------------------------------------------------------
            //
       //
     // <Header />
     // <NavBars />
     // <Routes>
       // <Route path="/" element={<Landing />} />
       // <Route path="/products" element={<Products />} />

        //<Route path="/detail/:category" element={<CategoryView />} />
     // </Routes>

     // <Footer></Footer>
    );
  }
}
import React, { Component } from 'react';

export class ManageOrderHistory extends Component {
  static displayName = ManageOrderHistory.name;

  constructor(props) {
    super(props);
    this.state = { orderHistory: [],  loadingOrderHistory: true};
  }

  componentDidMount() { //When cart component is mounted(loaded) the get request gets sent
    this.populateOrderHistoryData();
  }

  static renderOrderHistoryTable(orderHistory) { //orderHistory is a user-model
    return (

        <table className='table table-striped' aria-labelledby="tabelLabel">
          <thead>
            <tr>
              <th>Order id</th>
              <th>Cost</th>
            </tr>
          </thead>
          <tbody>
            {orderHistory.map(order => //Assuming the input is a user
              <tr key={order.OrderHistory.Id}>
                <td>{order.OrderHistory.Id }</td>
                <td>{order.OrderHistory.TotalCost }</td>
              </tr>
            )}
          </tbody>
        </table>
      );
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
                <a className='nav-link ' href='/managePassword'>Password</a>
            </li>           
            <li className='nav-item'>
                <a className='nav-link active ' href='/manageOrderHistory'>Order History</a>
            </li>
        </ul>
    </div>

    <div className='col-md-9'>
        <h4>Order history</h4>
        <div className='row'>
            <div className='col-md-6'>
                <p>My order history</p>
                {order_history_contents}
            </div>
        </div>
    </div>
</div>
);

    //if the get request isn't done, then 'Loading products' text is shown until the get request is completed.
    let order_history_contents = this.state.loadingOrderHistory
    ? <p><em>Loading order history...</em></p>
    : ManageOrderHistory.renderOrderHistoryTable(this.state.orderHistory);

    return (
        
      <div className='container'>
        <h2 id="tabelLabel" >Manage your account</h2>
        <h4>change your account settings</h4>
        <hr/>
        <RenderManageTable/>
      </div>
    );
  }

  async populateOrderHistoryData() {//YTODO: connect to backend
    //fetch('./api/CheckoutController/getallcategories')
    fetch('/api/CheckoutController/getallcartproducts')
        .then(response => response.json())
        .then(data => this.setState({ orderHistory: data.total, loadingOrderHistory: false }));

   
  }
}

import React, { useState } from "react";
import { useNavigate } from "react-router-dom";

function Checkout() {
  let products = JSON.parse(localStorage.getItem("existingEntries"));

  const navigate = useNavigate();
  const priceFun = (product) => {
    const new_price = product.count * product.price;
    console.log(new_price);
  };
  const movedToThankYou = () => {
    navigate("/thankyou");
    localStorage.clear();
  };
  return (
    <>
      <div className="container mb-5">
        <div className="row">
          <div className="col-9">
            {" "}
            <h1>Checkout</h1>
          </div>
          <div className="col-3">
            {" "}
            <button
              className="btn btn-primary"
              type="submit "
              style={{ float: "right" }}
              onClick={movedToThankYou}
            >
              Purchase
            </button>
          </div>
        </div>

        <hr />
        <div className="card">
          <div className="p-3">
            {products.map((product) => (
              <>
                <div
                  style={{
                    border: "1px solid black",
                    marginTop: 10 + "px",
                    padding: 5 + "px",
                  }}
                >
                  <div className="row">
                    <div className="col-3">{product.name}</div>
                    <div className="col-3">{product.count}</div>
                    <div className="col-3">{product.price}</div>
                    <div className="col-3">{product.count * product.price}</div>
                    {/* <div className="col-3">
                     
                    </div> */}
                  </div>
                </div>
              </>
            ))}
            <div className=" " style={{ float: "right" }}>
              <h3>
                Total Amount:{" "}
                {products.reduce(
                  (total, product) => total + product.price * product.count,
                  0
                )}
              </h3>
            </div>
          </div>
        </div>
      </div>
    </>
  );
}
export default Checkout;

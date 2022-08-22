import React, { useEffect } from "react";
import { useNavigate } from "react-router-dom";

function Cart() {
  let products = JSON.parse(localStorage.getItem("existingEntries"));
  const navigate = useNavigate();

  const removeItem = (product) => {
    // localStorage.setItem("existingEntries", JSON.stringify(products));
    // window.location.reload();
    // var itemKeys = Object.keys(products);
    // // console.log(itemKeys);
    // for (var i = 0; i < itemKeys.length; i++) {
    //     var key = itemKeys[i]
    //     console.log(key)
    //     localStorage.removeItem(key)
    // if (title === key ) {
    //     localStorage.removeItem(key)
    // }
    // }
    // localStorage.removeItem('existingEntries', product.id)
  };
  return (
    <>
      <div className="container">
        <h1>Shopping Cart</h1>
        <hr />
        <div className="row">
          <div className="col-3">
            <strong>Name</strong>{" "}
          </div>
          <div className="col-3">
            <strong>Qty</strong>{" "}
          </div>
          <div className="col-3">
            <strong>Price</strong>
          </div>
          <div className="col-3">
            {" "}
            <strong>Total</strong>
          </div>
          <div className="col-3"></div>
        </div>
        {!products || products === [] ? (
          <h4 className="text-center">Empty Cart</h4>
        ) : (
          products.map((product, index) => (
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

                  <div className="col-3">{product.price * product.count}</div>
                </div>
              </div>
              <div
                style={{
                  position: "relative",
                  left: "102%",

                  top: "-45px",
                  fontSize: "30px",
                }}
                onClick={(product) => {
                  let products = JSON.parse(
                    localStorage.getItem("existingEntries")
                  );
                //   const a =products.indexOf(product)
                  products.splice(product,1)
                //   const findIndex = products.findIndex(a => a.id === product.id)
                //   if(findIndex!==-1){
                //     products.splice(findIndex, 1);
                //     console.log(findIndex);
                //   }
             
                  

                  localStorage.setItem(
                    "existingEntries",
                    JSON.stringify(products)
                  );
                  
                  window.location.reload();
                }}
              >
                x
              </div>
            </>
          ))
        )}
        <div className="mt-3">
          {products  ? (
             <button
             className="btn btn-primary"
             onClick={() => navigate("/checkout")}
           >
             {" "}
             Go to CheckOut
           </button>
          ) : (
           ""
          )}
        </div>
      </div>
    </>
  );
}
export default Cart;

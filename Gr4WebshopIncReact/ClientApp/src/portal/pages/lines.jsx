import React from "react";

function Linebreak() {
  return (
    <>
      <div className="row " style={{ marginLeft: 2 + "px" }}>
        <div className="col-5">
          <hr />
        </div>
        <div className="col-2">
          <p
            className="text-center"
            style={{
              fontSize: "15px",
              fontSize: 17 + "px",
              fontWeight: "bold",
            }}
          >
            Lorem ipsum dolor
          </p>
        </div>
        <div className="col-5">
          <hr />
        </div>
      </div>

      <div>
        <img className="img-fluid" src="img/saleer.jpg" alt="" />
      </div>
    </>
  );
}
export default Linebreak;
import React from "react";

function SvgIcon() {
  return (
    <>
      <div style={{ marginTop: 50 + "px", marginBottom: 50 + "px" }}>
        <hr />
        <div className="container">
          <div className="row">
            <div className="col-2">
              <img
                height={50}
                width={50}
                src="svgsicon/delivery-svgrepo-com.svg"
                alt=""
              />
              <p>Tables </p>
            </div>
            <div className="col-2">
              <img
                height={50}
                width={50}
                src="svgsicon/checked-tick-svgrepo-com.svg"
                alt=""
              />
              <p>Tables </p>
            </div>
            <div className="col-2">
              <img
                height={50}
                width={50}
                src="svgsicon/file-content-svgrepo-com.svg"
                alt=""
              />
              <p>Tables </p>
            </div>
            <div className="col-2">
              <img
                height={50}
                width={50}
                src="svgsicon/light-bulb-svgrepo-com.svg"
                alt=""
              />
              <p>Tables </p>
            </div>
            <div className="col-2">
              <img
                height={50}
                width={50}
                src="svgsicon/businessman-connections-svgrepo-com.svg"
                alt=""
              />
              <p>Tables </p>
            </div>
            <div className="col-2">
              <img
                height={50}
                width={50}
                src="svgsicon/delivery-svgrepo-com.svg"
                alt=""
              />
              <p>Delivery Truk </p>
            </div>
            {/* <div className="col-2"></div> */}
          </div>
        </div>
      </div>
    </>
  );
}
export default SvgIcon;

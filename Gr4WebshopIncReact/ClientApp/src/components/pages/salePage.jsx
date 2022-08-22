import React from "react";

function SalePage() {
  return (
    <>
      <div className="container">
        <div
          className="row"
          style={{ marginTop: 50 + "px", marginBottom: 50 + "px" }}
        >
          <div className="col-6">
            <img className="img-fluid" src="img/silder.jpg" alt="" />
          </div>
          <div
            className="col-6"
            style={{
              display: "flex",
              justifyContent: "center",
              alignItems: "center",
            }}
          >
            Lorem ipsum dolor sit amet consectetur adipisicing elit. Reiciendis
            modi excepturi quasi unde, ullam deserunt quia, distinctio adipisci
            nemo eos sint fugiat iusto! Blanditiis eum, nam alias exercitationem
            voluptate magni?
          </div>
        </div>
      </div>
    </>
  );
}

export default SalePage;

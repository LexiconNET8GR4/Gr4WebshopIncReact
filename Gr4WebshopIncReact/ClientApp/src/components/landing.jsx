import React from "react";
import Category from "./pages/category";
import Home from "./pages/home";
import Linebreak from "./pages/lines";
import SalePage from "./pages/salePage";
import Sidler from "./pages/sidler";
import SvgIcon from "./pages/svgIcon";

function Landing() {
  return (
    <>
      <Home />

      <Category />

      <Linebreak />

      <div style={{ marginTop: 100 + "px", marginBottom: 60 + "px" }}>
        <Sidler></Sidler>
      </div>

      <SvgIcon></SvgIcon>

      <div style={{ marginTop: 60 + "px", marginBottom: 60 + "px" }}>
        <Sidler></Sidler>
      </div>

      <SalePage></SalePage>
    </>
  );
}

export default Landing;

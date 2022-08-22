import React from "react";
import { Link } from "react-router-dom";

function NavBars() {
  return (
    <>
      <hr />
      <div>
        <ul className="nav justify-content-center">
        <li className="nav-item">
            <a className="nav-link " aria-current="page" href="#">
              Collection
            </a>
          </li>
          
          <li className="nav-item">
            <a className="nav-link " aria-current="page" href="#">
              Limited Addition
            </a>
          </li>
          
          
          <li className="nav-item">
          <Link to="/products" style={{textDecoration: 'none', color: 'gray', position: 'relative', top: '6px'}}>  PRODUKTER </Link>
            
          </li>
          {/* <li className="nav-item">
          <Link to="/products" style={{textDecoration: 'none', color: 'gray', position: 'relative', top: '6px'}}>  CATEGORY </Link>
            
          </li> */}
          <li className="nav-item">
            <a className="nav-link " href="#" tabindex="-1">
              Om Oss
            </a>
          </li>
        </ul>
      </div>
      <hr />
    </>
  );
}

export default NavBars;

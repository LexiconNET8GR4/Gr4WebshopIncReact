import React, { useEffect, useState } from "react";
import axios from "axios";
import { useParams } from "react-router-dom";

function CategoryView() {
  const [productsList, setProductsList] = useState([]);
  const { category } = useParams();
  useEffect(() => {
    axios
      .get('api/product/getallproducts')
      .then((response) => {
        return response.data;
      })
      .then((product) => {
        return setProductsList(product);
      });
  }, []);
  return (
    <>
      <div className="container mt-3">
        <div className="row">
          {console.log(category)}
          {productsList
            .filter((f) => f.category === category)
            .map((p) => (
              <div className="col-3">
                <span
                  style={{
                    float: "right",
                    position: "relative",
                    top: 30 + "px",
                  }}
                >
                  <svg
                    xmlns="http://www.w3.org/2000/svg"
                    width="16"
                    height="16"
                    fill="currentColor"
                    class="bi bi-heart"
                    viewBox="0 0 16 16"
                  >
                    <path d="m8 2.748-.717-.737C5.6.281 2.514.878 1.4 3.053c-.523 1.023-.641 2.5.314 4.385.92 1.815 2.834 3.989 6.286 6.357 3.452-2.368 5.365-4.542 6.286-6.357.955-1.886.838-3.362.314-4.385C13.486.878 10.4.28 8.717 2.01L8 2.748zM8 15C-7.333 4.868 3.279-3.04 7.824 1.143c.06.055.119.112.176.171a3.12 3.12 0 0 1 .176-.17C12.72-3.042 23.333 4.867 8 15z" />
                  </svg>
                </span>

                <img
                  src="img/category-2.webp"
                  className="card-img-top"
                  alt="..."
                  style={{ width: 200 + "px" }}
                />
                <div className="card-body">
                  <p className="card-text">{p?.richDescription}</p>
                  <h5 className="card-title">
                    {" "}
                    {p?.price + "$"}
                  </h5>
                  <p>
                    <span className="fa fa-star checked"></span>
                    <span className="fa fa-star checked"></span>
                    <span className="fa fa-star checked"></span>
                    <span className="fa fa-star checked"></span>
                    <span className="fa fa-star checked"></span>
                  </p>
                  <div style={{ display: "flex", gap: 10 + "px" }}>
                    <p
                      style={{
                        background: "red",
                        borderRadius: 25 + "px",
                        border: "2px solid red",
                        width: 20 + "px",
                        height: 20 + "px",
                      }}
                    ></p>
                  </div>
                  <p style={{ fontSize: 11 + "px", color: "green" }}>
                    Lorem, ipsum dolor sit amet consectetur{" "}
                  </p>
                </div>
              </div>
            ))}
        </div>
      </div>
    </>
  );
}
export default CategoryView;
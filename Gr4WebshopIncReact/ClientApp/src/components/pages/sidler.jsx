import React, { useEffect, useState } from "react";
import axios from "axios";
import Carousel from "react-grid-carousel";
function Sidler() {
  const [productsList, setProductsList] = useState([]);
  useEffect(() => {
    axios
      .get('api/product/getallproducts')
      .then((response) => {
        return response.data;
      })
      .then((c) => {
        // console.log(c.filter((f) => f.isFeatured === true));
        return setProductsList(c);
      });
  }, []);
  return (
    <>
      <div>
        <Carousel cols={4} rows={1} gap={10} loop>
          <Carousel.Item>
            <>
              <span
                style={{ float: "right", position: "relative", top: 30 + "px" }}
              >
                <svg
                  xmlns="http://www.w3.org/2000/svg"
                  width="16"
                  height="16"
                  fill="currentColor"
                  className="bi bi-heart"
                  viewBox="0 0 16 16"
                >
                  <path d="m8 2.748-.717-.737C5.6.281 2.514.878 1.4 3.053c-.523 1.023-.641 2.5.314 4.385.92 1.815 2.834 3.989 6.286 6.357 3.452-2.368 5.365-4.542 6.286-6.357.955-1.886.838-3.362.314-4.385C13.486.878 10.4.28 8.717 2.01L8 2.748zM8 15C-7.333 4.868 3.279-3.04 7.824 1.143c.06.055.119.112.176.171a3.12 3.12 0 0 1 .176-.17C12.72-3.042 23.333 4.867 8 15z" />
                </svg>
              </span>

              <img
                src="img/category-3.webp"
                className="card-img-top"
                alt="..."
                style={{}}
              />
              <div className="card-body">
                <p className="card-text">
                  Some quick example text to build on the card title.
                </p>
                <h5 className="card-title">550Kr</h5>
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
            </>
          </Carousel.Item>
          <Carousel.Item>
            <>
              <span
                style={{ float: "right", position: "relative", top: 30 + "px" }}
              >
                <svg
                  xmlns="http://www.w3.org/2000/svg"
                  width="16"
                  height="16"
                  fill="currentColor"
                  className="bi bi-heart"
                  viewBox="0 0 16 16"
                >
                  <path d="m8 2.748-.717-.737C5.6.281 2.514.878 1.4 3.053c-.523 1.023-.641 2.5.314 4.385.92 1.815 2.834 3.989 6.286 6.357 3.452-2.368 5.365-4.542 6.286-6.357.955-1.886.838-3.362.314-4.385C13.486.878 10.4.28 8.717 2.01L8 2.748zM8 15C-7.333 4.868 3.279-3.04 7.824 1.143c.06.055.119.112.176.171a3.12 3.12 0 0 1 .176-.17C12.72-3.042 23.333 4.867 8 15z" />
                </svg>
              </span>
              <img
                src="img/category-4.webp"
                className="card-img-top"
                alt="..."
                style={{}}
              />
              <div className="card-body">
                <p className="card-text">
                  Some quick example text to build on the card title.
                </p>
                <h5 className="card-title">350Kr</h5>
                <p>
                  <span className="fa fa-star checked"></span>
                  <span className="fa fa-star checked"></span>
                  <span className="fa fa-star checked"></span>
                  <span className="fa fa-star"></span>
                  <span className="fa fa-star"></span>
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
                  <p
                    style={{
                      background: "blue",
                      borderRadius: 25 + "px",
                      border: "2px solid blue",
                      width: 20 + "px",
                      height: 20 + "px",
                    }}
                  ></p>
                </div>
                <p style={{ fontSize: 11 + "px", color: "green" }}>
                  Lorem, ipsum dolor sit amet consectetur{" "}
                </p>
              </div>
            </>
          </Carousel.Item>
          <Carousel.Item>
            <>
              <span
                style={{ float: "right", position: "relative", top: 30 + "px" }}
              >
                <svg
                  xmlns="http://www.w3.org/2000/svg"
                  width="16"
                  height="16"
                  fill="currentColor"
                  className="bi bi-heart"
                  viewBox="0 0 16 16"
                >
                  <path d="m8 2.748-.717-.737C5.6.281 2.514.878 1.4 3.053c-.523 1.023-.641 2.5.314 4.385.92 1.815 2.834 3.989 6.286 6.357 3.452-2.368 5.365-4.542 6.286-6.357.955-1.886.838-3.362.314-4.385C13.486.878 10.4.28 8.717 2.01L8 2.748zM8 15C-7.333 4.868 3.279-3.04 7.824 1.143c.06.055.119.112.176.171a3.12 3.12 0 0 1 .176-.17C12.72-3.042 23.333 4.867 8 15z" />
                </svg>
              </span>
              <img
                src="img/category-5.webp"
                className="card-img-top"
                alt="..."
                style={{}}
              />
              <div className="card-body">
                <p className="card-text">
                  Some quick example text to build on the card title.
                </p>
                <h5 className="card-title">255Kr</h5>
                <p>
                  <span className="fa fa-star checked"></span>
                  <span className="fa fa-star checked"></span>
                  <span className="fa fa-star checked"></span>
                  <span className="fa fa-star"></span>
                  <span className="fa fa-star"></span>
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
                  <p
                    style={{
                      background: "blue",
                      borderRadius: 25 + "px",
                      border: "2px solid blue",
                      width: 20 + "px",
                      height: 20 + "px",
                    }}
                  ></p>
                  <p
                    style={{
                      background: "gray",
                      borderRadius: 25 + "px",
                      border: "2px solid gray",
                      width: 20 + "px",
                      height: 20 + "px",
                    }}
                  ></p>
                </div>
                <p style={{ fontSize: 11 + "px", color: "green" }}>
                  Lorem, ipsum dolor sit amet consectetur{" "}
                </p>
              </div>
            </>
          </Carousel.Item>
          <Carousel.Item>
            <>
              <img
                src="img/category-2.webp"
                className="card-img-top"
                alt="..."
                style={{}}
              />
              <div className="card-body">
                <p className="card-text">
                  Some quick example text to build on the card title.
                </p>
                <h5 className="card-title">525Kr</h5>
                <p>
                  <span className="fa fa-star checked"></span>
                  <span className="fa fa-star checked"></span>
                  <span className="fa fa-star checked"></span>
                  <span className="fa fa-star"></span>
                  <span className="fa fa-star"></span>
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
                  <p
                    style={{
                      background: "blue",
                      borderRadius: 25 + "px",
                      border: "2px solid blue",
                      width: 20 + "px",
                      height: 20 + "px",
                    }}
                  ></p>
                  <p
                    style={{
                      background: "gray",
                      borderRadius: 25 + "px",
                      border: "2px solid gray",
                      width: 20 + "px",
                      height: 20 + "px",
                    }}
                  ></p>
                </div>
                <p style={{ fontSize: 11 + "px", color: "green" }}>
                  Lorem, ipsum dolor sit amet consectetur{" "}
                </p>
              </div>
            </>
          </Carousel.Item>
          <Carousel.Item>
            <>
              <span
                style={{ float: "right", position: "relative", top: 30 + "px" }}
              >
                <svg
                  xmlns="http://www.w3.org/2000/svg"
                  width="16"
                  height="16"
                  fill="currentColor"
                  className="bi bi-heart"
                  viewBox="0 0 16 16"
                >
                  <path d="m8 2.748-.717-.737C5.6.281 2.514.878 1.4 3.053c-.523 1.023-.641 2.5.314 4.385.92 1.815 2.834 3.989 6.286 6.357 3.452-2.368 5.365-4.542 6.286-6.357.955-1.886.838-3.362.314-4.385C13.486.878 10.4.28 8.717 2.01L8 2.748zM8 15C-7.333 4.868 3.279-3.04 7.824 1.143c.06.055.119.112.176.171a3.12 3.12 0 0 1 .176-.17C12.72-3.042 23.333 4.867 8 15z" />
                </svg>
              </span>
              <img
                src="img/category-3.webp"
                className="card-img-top"
                alt="..."
                style={{}}
              />
              <div className="card-body">
                <p className="card-text">
                  Some quick example text to build on the card title.
                </p>
                <h5 className="card-title">250Kr</h5>
                <p>
                  <span className="fa fa-star checked"></span>
                  <span className="fa fa-star checked"></span>
                  <span className="fa fa-star checked"></span>
                  <span className="fa fa-star"></span>
                  <span className="fa fa-star"></span>
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
                  <p
                    style={{
                      background: "blue",
                      borderRadius: 25 + "px",
                      border: "2px solid blue",
                      width: 20 + "px",
                      height: 20 + "px",
                    }}
                  ></p>
                  <p
                    style={{
                      background: "gray",
                      borderRadius: 25 + "px",
                      border: "2px solid gray",
                      width: 20 + "px",
                      height: 20 + "px",
                    }}
                  ></p>
                </div>
                <p style={{ fontSize: 11 + "px", color: "green" }}>
                  Lorem, ipsum dolor sit amet consectetur{" "}
                </p>
              </div>
            </>
          </Carousel.Item>
        </Carousel>
      </div>
    </>
  );
}

export default Sidler;

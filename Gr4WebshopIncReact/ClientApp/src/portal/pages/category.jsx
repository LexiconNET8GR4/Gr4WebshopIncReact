import React, { useEffect, useState } from "react";
import axios from "axios";
import { useNavigate } from "react-router-dom";
import CategoryView from "./detailCategory";
function Category() {
  const [categoryList, setCategoryList] = useState([]);
  const [getDataFromInput, setGetDataFromInput] = useState([]);
  const categories = [
    { name: "Sofa", imageCat: "img/category-1.webp" },
    { name: "Table", imageCat: "img/category-2.webp" },
    { name: "Bed", imageCat: "img/category-3.webp" },
    { name: "Sideboard", imageCat: "img/category-4.webp" },
    { name: "Chair", imageCat: "img/category-2.webp" },
  ];
  const navigate = useNavigate();
  const filterCategory = (e) => {
    e.preventDefault();
    const inputVal = e.target.innerHTML;
    
    // console.log(inputVal);
    axios
      .get("http://localhost:3000/products")
      .then((response) => {
        return response.data;
      })
      .then((c) => {
        const filtrate = c.filter((a) => a.category === inputVal);
        // console.log(filtrate);
        navigate(`/detail/${e.target.innerHTML}`);
        return setCategoryList(filtrate);
        
      });
      return setGetDataFromInput(e.target.innerHTML)
  };
  return (
    <>
      <div className="container mt-3">
        <div className="row">
          {categories.map((cat) => (
            <div className="col-3">
              <img className="categoryImg" src="img/category-2.webp" alt="" />
              <p className="categorytext" onClick={filterCategory}>
                {/* Rosa Bed */}
                {cat.name}
              </p>
            </div>
          ))}
          {/* <CategoryView data={getDataFromInput} /> */}
        </div>
      </div>
    </>
  );
}

export default Category;

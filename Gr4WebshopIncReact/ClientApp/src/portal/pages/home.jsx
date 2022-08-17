import React from "react";
import Carousel from "react-grid-carousel";
function Home() {
  return (
    <>
      <div style={{ marginTop: 15 + "px" }}>
        <Carousel cols={1} rows={1} loop>
          <Carousel.Item>
            <>
              <img
                src="img/Desktop-sliders.jpg"
                className="card-img-top"
                alt="..."
                style={{}}
              />
            </>
          </Carousel.Item>
          <Carousel.Item>
            <>
              <img
                src="img/Desktop-sliders_5e4c18ad-f2d9-4a84-8609-320ead989087.jpg"
                className="card-img-top"
                alt="..."
                style={{}}
              />
            </>
          </Carousel.Item>
          <Carousel.Item>
            <>
              <img
                src="img/Desktop-sliders_8c78ad80-4278-4acd-82f7-d2ec27b300e5.jpg"
                className="card-img-top"
                alt="..."
                style={{}}
              />
            </>
          </Carousel.Item>
          <Carousel.Item>
            <>
              <img
                src="img/carsoule.jpg"
                className="card-img-top"
                alt="..."
                style={{}}
              />
            </>
          </Carousel.Item>
        </Carousel>
      </div>
    </>
  );
}

export default Home;

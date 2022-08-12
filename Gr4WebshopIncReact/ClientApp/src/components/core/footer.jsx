import React from "react";

function Footer() {
  return (
    <>
      <footer className="footer " style={{ marginTop: "15px" }}>
        <div className="container">
          <div className="row">
            <div className="col-sm-3">
              <div className="footer-widget">
                <h5 style={{fontSize: 18 +'px'}}>Om</h5>
                <hr />
                <div className="footer-widget-content">
                  <div className="footer-social">
                    <ul>
                      <li className="changeIcon">Hem</li>
                      <li className="changeIcon">Om oss</li>
                      <li className="changeIcon">Hallbart</li>
                    </ul>
                  </div>
                </div>
              </div>
            </div>
            <div className="col-sm-3">
              <div className="footer-widget">
                <h5 style={{fontSize: 18 +'px'}}>Tjanster</h5>
                <hr />
                <div className="footer-widget-content">
                  <ul>
                    <li className="changeIcon">FAQ</li>
                    <li className="changeIcon">Kontakt</li>
                    <li className="changeIcon">Leverans</li>
                    <li className="changeIcon">Leverans</li>
                    <li className="changeIcon">Leverans</li>
                  </ul>
                </div>
              </div>
            </div>
            <div className="col-sm-3">
              <div className="footer-widget">
                <h5 style={{fontSize: 18 +'px'}}>Anvandarvillkor</h5>
                <hr />
                <div className="footer-widget-content">
                  <ul>
                    <li className="changeIcon">FAQ</li>
                    <li className="changeIcon">Kontakt</li>
                    <li className="changeIcon">Leverans</li>
                    <li className="changeIcon">Leverans</li>
                    <li className="changeIcon">Leverans</li>
                  </ul>
                </div>
              </div>
            </div>

            <div className="col-sm-3 mb-4">
              <div className="footer-widget">
                <h5 style={{fontSize: 18 +'px'}}>Serviceformaner</h5>
                <hr />
                <div className="footer-widget-content">
                  <div className="images-gellary">
                  <ul>
                    <li className="changeIcon">FAQ</li>
                    <li className="changeIcon">Kontakt</li>
                    <li className="changeIcon">Leverans</li>
                    <li className="changeIcon">Leverans</li>
                    <li className="changeIcon">Leverans</li>
                  </ul>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </footer>
    </>
  );
}

export default Footer;

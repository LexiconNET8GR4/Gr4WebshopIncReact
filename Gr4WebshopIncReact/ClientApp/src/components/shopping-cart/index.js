import React from "react";
import ReactDOM from "react-dom";
import { BrowserRouter as Router, Route, Link } from "react-router-dom";
import cardData from "./cardData";

// If this example helped you, give it an upvote on SO :)
// Code written to help answer SO question: https://stackoverflow.com/questions/51906708/keep-scrolling-history-with-react-router

// cards list compoment
 class Cards extends React.Component {
  componentDidMount() {
    const item = document.querySelector(
      ".restore-" + this.props.location.state
    );
    if (item) {
      item.scrollIntoView();
    }
  }

  render() {
    const cardKeys = Object.keys(cardData);
    return (
      <ul className="scroll-list">
        {cardKeys.map(id => {
          return (
            <Link
              to={{ pathname: `/cards/${id}`, state: id }}
              className={`card-wrapper restore-${id}`}
            >
              {cardData[id].name}
            </Link>
          );
        })}
      </ul>
    );
  }
}

// Card details compoment
const Card = props => {
  const { id } = props.match.params;
  return (
    <div className="card-details">
      <h2>{cardData[id].name}</h2>
      <img alt={cardData[id].name} src={cardData[id].image} />
      <p>
        {cardData[id].description}&nbsp;<a href={cardData[id].url}>More...</a>
      </p>
      <Link
        to={{
          pathname: "/cards",
          state: props.location.state
        }}
      >
        <button>Return to list</button>
      </Link>
    </div>
  );
};

// Main App router compoment 
/*function App() {
  return (
    <div className="App">
      <Router>
        <div>
          <Route exact path="/cards" component={Cards} />
          <Route path="/cards/:id" component={Card} />
        </div>
      </Router>
    </div>
  );
}*/

const rootElement = document.getElementById("root");
ReactDOM.render(<App />, rootElement);

// If this example helped you, give it an upvote on SO :)
// Code written to help answer SO question: https://stackoverflow.com/questions/51906708/keep-scrolling-history-with-react-router

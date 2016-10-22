"use strict";

var React = require('react');
var ReactDOM = require('react-dom');
var Header = require('./components/header.jsx');
var Log = require('./components/log.jsx');
var axios = require('axios');

var renderApp = function (accounts) {
    ReactDOM.render(
        <div className="container">
            <Header />
            <Log accounts={accounts} />
        </div>,
        document.getElementById('app'));
}


axios.get("http://localhost:5051/api/accounts")
    .then(function (response) {
        renderApp(response.data);
    });

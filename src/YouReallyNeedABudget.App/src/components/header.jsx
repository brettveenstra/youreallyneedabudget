"use strict";

var React = require('react');

var Header = React.createClass({
    render: function() {
        return (
            <div>
                <h1>YouReallyNeedABudget</h1>
                <p>A simple budgeting tool built with ASP.NET Core and React.</p>
            </div>
        );
    }
});

module.exports = Header;
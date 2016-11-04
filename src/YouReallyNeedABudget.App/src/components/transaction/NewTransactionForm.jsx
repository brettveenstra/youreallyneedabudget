import React from 'react';

export default class NewTransactionForm extends React.Component {

    constructor(props) {
        super(props);
        this.state = {
            date: '', 
            memo: '', 
            payee: '', 
            amount: '', 
            cleared: false 
        }
        this.handleDateChange = this.handleDateChange.bind(this);
        this.handlePayeeChange = this.handlePayeeChange.bind(this);
        this.handleMemoChange = this.handleMemoChange.bind(this);
        this.handleAmountChange = this.handleAmountChange.bind(this);
        this.handleClearedChange = this.handleDateChange.bind(this);
        this.handleSubmit = this.handleSubmit.bind(this);
    }

    render() {
        return (
            <form className="form-inline" onSubmit={this.handleSubmit}>
                <input type="date" className="form-control"  name="date" onChange={this.handleDateChange} placeholder="Date" value={this.state.date} />
                <input type="text" className="form-control"  name="payee" onChange={this.handlePayeeChange} placeholder="Payee" value={this.state.payee} />
                <input type="text" className="form-control" name="memo" onChange={this.handleMemoChange} placeholder="Memo" value={this.state.memo} />
                <input type="text" className="form-control" name="amount" onChange={this.handleAmountChange} placeholder="Amount" value={this.state.amount} />
                <input type="checkbox" className="form-control" name="cleared" onChange={this.handleClearedChange} value={this.state.cleared} />
                <input type="submit" className="btn btn-default" value="Save" />
            </form>
        );
    }

    handleDateChange(e) {
        this.setState({date: e.target.value});
    }

    handlePayeeChange(e) {
        this.setState({payee: e.target.value});
    }

    handleMemoChange(e) {
        this.setState({memo: e.target.value});
    }

    handleAmountChange(e) {
        this.setState({amount: e.target.value});
    }

    handleClearedChange(e) {
        this.setState({cleared: e.target.checked})
    }

    handleSubmit(e) {

        e.preventDefault();

        var transaction = {
            accountid: this.props.account.id,
            date: this.state.date.trim(),
            memo: this.state.memo.trim(),
            amount: this.state.amount.trim(),
            cleared: this.state.cleared
        }

        this.props.onFormSubmitted(transaction);

        this.setState({
            date: '',
            memo: '', 
            payee: '', 
            amount: '', 
            cleared: false
        });
    }
}

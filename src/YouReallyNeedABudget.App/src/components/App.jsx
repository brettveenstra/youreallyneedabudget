import React from 'react';
import Header from './header.jsx';
import AccountList from './account/AccountList.jsx';
import TransactionTable from './transaction/TransactionTable.jsx';
import NewTransactionForm from './transaction/NewTransactionForm.jsx';
import BudgetApi from '../data/BudgetApi';

export default class App extends React.Component {

    constructor() {
        super();
        this.state = {
            accounts: [],
            selectedAccountId: 0
        };
        this.handleAccountListItemSelected = this.handleAccountListItemSelected.bind(this);
        this.handleNewTransactionFormSubmitted = this.handleNewTransactionFormSubmitted.bind(this);
        this.handleDeleteTransactionClicked = this.handleDeleteTransactionClicked.bind(this);
        this.getSelectedAccount = this.getSelectedAccount.bind(this);
        this.refreshAccounts = this.refreshAccounts.bind(this);
    }

    render() {
        return (
            <div className="container">
                <Header />
                <AccountList accounts={this.state.accounts} onItemSelected={this.handleAccountListItemSelected} />
                <TransactionTable account={this.getSelectedAccount()} onDeleteTransactionClicked={this.handleDeleteTransactionClicked} />
                <NewTransactionForm account={this.getSelectedAccount()} onFormSubmitted={this.handleNewTransactionFormSubmitted} />
            </div>
        );
    }

    componentDidMount() {
        this.refreshAccounts();
    }

    refreshAccounts() {
        BudgetApi.getAccounts()
            .then(response => {
                this.setState({
                    accounts: response.data
                });
            });
    }

    handleAccountListItemSelected(selectedAccountId) {
        this.setState({
            selectedAccountId: selectedAccountId
        });
    }

    handleNewTransactionFormSubmitted(transaction) {
        BudgetApi.addTransaction(transaction)
            .then(response => {
                this.refreshAccounts();
            });
    }

    handleDeleteTransactionClicked(transactionId) {
        BudgetApi.deleteTransaction(transactionId)
            .then(response => {
                this.refreshAccounts();
            });
    }

    getSelectedAccount() {
        for (var i = 0; i < this.state.accounts.length; i++) {
            if (this.state.accounts[i].id == this.state.selectedAccountId) {
                return this.state.accounts[i];
            }
        }
    }
}


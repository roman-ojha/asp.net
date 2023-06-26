import React, { Component } from 'react';
import { Route, Routes } from 'react-router-dom';
import AppRoutes from './AppRoutes';
import { Layout } from './components/Layout';
import './custom.css';

export default class App extends Component {
    constructor(props) {
        super(props);
        this.state = {
            username: '',
            password: '',
            errors: {
                username: '',
                password: '',
            },
        };
    }

    handleInputChange = (event) => {
        const { name, value } = event.target;
        this.setState((prevState) => ({
            [name]: value,
            errors: {
                ...prevState.errors,
                [name]: '',
            },
        }));
    };

    handleSubmit = (event) => {
        event.preventDefault();
        const { username, password } = this.state;
        const errors = {};

        if (!username) {
            errors.username = 'Username is required';
        }

        if (!password) {
            errors.password = 'Password is required';
        }

        if (Object.keys(errors).length > 0) {
            this.setState({ errors });
        } else {
            // Perform login logic here
            window.alert('Login successful');
        }
    };

    render() {
        const { username, password, errors } = this.state;

        return (
            <div>
                <h1>Login</h1>
                <form onSubmit={this.handleSubmit}>
                    <div>
                        <label>Username:</label>
                        <input
                            type="text"
                            name="username"
                            value={username}
                            onChange={this.handleInputChange}
                        />
                        {errors.username && <span>{errors.username}</span>}
                    </div>
                    <div>
                        <label>Password:</label>
                        <input
                            type="password"
                            name="password"
                            value={password}
                            onChange={this.handleInputChange}
                        />
                        {errors.password && <span>{errors.password}</span>}
                    </div>
                    <button type="submit">Login</button>
                </form>
            </div>
        );
    }
}

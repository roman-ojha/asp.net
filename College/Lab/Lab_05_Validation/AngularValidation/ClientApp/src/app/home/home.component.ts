import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-login-page',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  loginForm: FormGroup;
  formSubmitted = false;

  constructor(private formBuilder: FormBuilder) {
    this.loginForm = this.formBuilder.group({
      username: ['', Validators.required],
      password: ['', Validators.required]
    });
  }

  login() {
    this.formSubmitted = true;
    if (this.loginForm.invalid) {
      return;
    }
    // Perform login logic here
    window.alert('Login successful');
    // Reset the form after successful login
    this.loginForm.reset();
  }
}

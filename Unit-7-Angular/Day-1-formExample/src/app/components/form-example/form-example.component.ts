import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { throwError } from 'rxjs';

@Component({
  selector: 'form-example',  // Name used in html to reference the component <form-example>
  standalone: true,
  imports: [FormsModule],  // Tell Angular we want Forms support for this code
  templateUrl: './form-example.component.html',
  styleUrl: './form-example.component.css'
})
// Allow access to stuff defined this component from outside the component
export class FormExampleComponent {
  buttonClicked = false
  firstName = "" //  hold the data from the first name field in the form
  lastName = ""
  birthday = ""
  foodPreference = ""
  emailAddress = ""
  sendEmail = ""
  sports: any[] = [] 



  onSubmit() { // Handle the Submit button click on the  form
    this.buttonClicked = true
    console.log(`OK.... You Clicked Submit`)
    console.log(`You entered: ${this.firstName} in the First Name field`)
    console.log(`You entered: ${this.lastName} in the Last Name field`)
    console.log(`You entered: ${this.birthday} in the Birthday field`)
    console.log(`You entered: ${this.foodPreference} in the Food Preference field`)
    console.log(`You entered: ${this.emailAddress} in the Email Address field`)
    console.log(`You entered: ${this.sendEmail} in the Send Email field`)
    console.log(`You entered: ${this.sports} in the Sports field`)
  }
}
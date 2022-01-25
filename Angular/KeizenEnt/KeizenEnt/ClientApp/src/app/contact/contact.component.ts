import { Component } from '@angular/core';

@Component({
  selector: 'app-contact-component',
  templateUrl: './contact.component.html'
})
export class ContactComponent {
  public currentCount = 1;

  public incrementCounter() {
    this.currentCount++;
  }
}

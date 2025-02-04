import { Component } from '@angular/core';

@Component({
  selector: 'app-home',
  imports: [],
  templateUrl: './home.component.html',
  styleUrl: './home.component.css',
})
export class HomeComponent {
  //var que podem ser acessados dentro do ambiente HomeComponent
  name = 'Luiz Eduardo';
  idButton = 'Login';
  mustShowTitle = false;
  listItems = ['item1', 'item2', 'item3', 'item4'];

  submit() {
    console.log('CLicado');
  }

  returnEvent(event: any) {
    console.log(event);
  }
}

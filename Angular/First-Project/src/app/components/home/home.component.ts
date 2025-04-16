import {
  Component,
  EventEmitter,
  inject,
  Input,
  input,
  Output,
} from '@angular/core';
import { SubmitFormService } from '../../services/submit-form.service';

@Component({
  selector: 'app-home',
  imports: [],
  templateUrl: './home.component.html',
  styleUrl: './home.component.css',
})
export class HomeComponent {
  //var que podem ser acessados dentro do ambiente HomeComponent
  name = 'Luiz Eduardo Mazzini';
  idButton = 'Login';
  mustShowTitle = false;
  listItems = ['item1', 'item2', 'item3', 'item4'];

  //instanciando service para ser usado nesse ambiente
  private SubmitService = inject(SubmitFormService);

  //recebendo o valor de fora
  @Input('name') propsDeFora!: string;

  //enviando valor para fora
  @Output() emitindoValorName = new EventEmitter<string>();

  returnEvent(event: any) {
    console.log(event);
  }

  submit() {
    this.emitindoValorName.emit(this.name);
    this.SubmitService.SubmitForm();
  }
}

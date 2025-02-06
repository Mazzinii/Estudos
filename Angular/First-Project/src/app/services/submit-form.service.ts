import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class SubmitFormService {
  constructor() {}

  SubmitForm() {
    console.log('Formulario Enviado');
  }
}

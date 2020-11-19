import { Component, OnInit } from '@angular/core';
import { PagoService } from 'src/app/services/pago.service';
import { PersonaService } from 'src/app/services/persona.service';
import { Pago } from '../models/pago';
import { Persona } from '../models/persona';

@Component({
  selector: 'app-pago-registro',
  templateUrl: './pago-registro.component.html',
  styleUrls: ['./pago-registro.component.css']
})
export class PagoRegistroComponent implements OnInit {


  constructor(private personaService: PersonaService, private pagoService: PagoService) { }

  persona: Persona;
  personas: Persona[];
  pago: Pago;
  search: string;
  ngOnInit(): void {
    this.persona = new Persona();
    this.persona.NumeroDeDocumento="1033";
    this.pago = new Pago();
    this.personaService.get().subscribe(result => {
      this.personas = result;
    });
  }

  public buscarTercero() {

    this.personas.forEach(element => {
      if (element.NumeroDeDocumento === this.search) {
        this.persona = element; 
        alert(JSON.stringify(this.persona));
      }

    });
      
  }

  get() {
    /* alert(JSON.stringify(this.personas)); */
    this.buscarTercero();
    if (this.persona == null) {
      alert("Persona no encontrada");
    }
  }

  add() {
    this.pago.Persona=this.persona;
    this.pagoService.post(this.pago).subscribe(p => {
      if (p != null) {
        alert('Pago Registrado!');
        this.pago = p;
        
      }
    });
  }
}

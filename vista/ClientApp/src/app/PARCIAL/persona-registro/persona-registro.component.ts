import { Component, OnInit } from '@angular/core';
import { PersonaService } from 'src/app/services/persona.service';
import { Persona } from '../models/persona';

@Component({
  selector: 'app-persona-registro',
  templateUrl: './persona-registro.component.html',
  styleUrls: ['./persona-registro.component.css']
})
export class PersonaRegistroComponent implements OnInit {
  persona: Persona;
  constructor(private personaService: PersonaService) { }


  ngOnInit(): void {
    this.persona = new Persona();
  }

  add() {
    this.personaService.post(this.persona).subscribe(p => {
      if (p != null) {
        alert('Persona creada!');
        this.persona = p;
      }
    });

  }

  
}

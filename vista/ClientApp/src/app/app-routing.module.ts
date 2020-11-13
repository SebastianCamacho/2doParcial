import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { PersonaRegistroComponent } from './Parcial/persona-registro/persona-registro.component';
import { PagoRegistroComponent } from './Parcial/pago-registro/pago-registro.component';
import { PagoConsultaComponent } from './Parcial/pago-consulta/pago-consulta.component';

const routes: Routes = [
  {
    path: 'pagoConsulta',
    component: PagoConsultaComponent
    },
  {
  path: 'pagoRegistro',
  component: PagoRegistroComponent
  },
  {
  path: 'personaRegistro',
  component: PersonaRegistroComponent
  }
  ];
  


@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    RouterModule.forRoot(routes)
    ],
    exports:[RouterModule]
    })
    
export class AppRoutingModule { }

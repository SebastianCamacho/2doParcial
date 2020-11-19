import { Persona } from "./persona";

export class Pago {
    public idDePago:string;
    public tipoDePago:string;
    public fecha:string;
    public valorDePago:string;
    public valorIva:string;
    public persona:Persona;
}

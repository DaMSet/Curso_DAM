export class Juego {


    private nombre : string;
    private compania : string;
    private precio : number;

    constructor(nombre:string, compania:string, precio:number){

        this.nombre = nombre;
        this.compania = compania;
        this.precio = precio;

    }


    public getnombre(){
        return this.nombre;
    }

    public setnombre(nombre:string){
        this.nombre = nombre;
    }

    public getcompania(){
        return this.compania;
    }

    public setcompania(compania:string){
        this.compania = compania;
    }

    public getprecio(){
        return this.precio;
    }

    public setprecio(precio:number){
        this.precio = precio;
    }

}

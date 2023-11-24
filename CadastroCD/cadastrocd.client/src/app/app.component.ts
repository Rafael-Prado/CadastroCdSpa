import { Component, OnInit } from '@angular/core';
import { AppDataService } from './app.dataService ';

interface Cdmusica {
  id: number;
  artista: string;
  titulo: string;
  generoMusical: string;
  musicas: Musica[];
}
interface Musica {
  id: number;
  idCd: number;
  nomeMusica: string;
  tempoMusica: string;  
}

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'cadastrocd.client';
  public cds: Cdmusica[] = [];
  public musicas: Musica[] = [];

  constructor(private dataService: AppDataService) {}

  ngOnInit() {
    this.getcds();
  }

  getcds() {
    this.dataService.Get().subscribe(
      (result) => {
        console.log(result);
        this.cds = result;
      },
      (error) => {
        console.error(error);
      }
    );
  };

  listarMusicas(idCd: number): void {
    let mus = this.cds.find((element) => element.id == idCd)?.musicas;
    if (mus != undefined) {
      this.musicas = mus;
    }

  }
  
}

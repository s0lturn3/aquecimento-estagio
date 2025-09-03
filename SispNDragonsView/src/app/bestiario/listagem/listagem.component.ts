import { CommonModule } from '@angular/common';
import { Component, inject, OnInit } from '@angular/core';
import { RouterLink } from '@angular/router';
import { IBestiarioRecord } from '../models/bestiario.model';
import { BestiarioService } from '../services/bestiario.service';

@Component({
  selector: 'app-listagem',
  imports: [
    CommonModule,
    RouterLink
],
  templateUrl: './listagem.component.html',
  styleUrl: './listagem.component.scss'
})
export class ListagemComponent implements OnInit {

  // #region Properties

  // Criei esta variável aqui para exemplificar que na prática não há diferença (pelo menos não para a nossa situação atual) entre injetar o serviço no construtor ou usar o inject()
  private _bestiario: BestiarioService = inject(BestiarioService);

  // Variável de lista que vai armazenar os nossos registros que vieram da API
  public listaBestiario?: IBestiarioRecord[];

  // #endregion Properties


  // Injetar o serviço pelo constructor é uma das formas de disponibilizá-lo dentro do nosso componente
  constructor( private _bestiarioService: BestiarioService ) { }

  ngOnInit(): void {
    this.getCriaturas();
  }


  // #region Methods

  // Método público que chama o método do meu service e o resultado da API ele já atribui à minha variável de lista
  public getCriaturas() {

    // Como o retorno do método do service é um Observable<IBestiarioRecord[]>, precisamos nos inscrever nele para obter os dados
    this._bestiario.getBestiarioList().subscribe({
      next: data => {     // O next é chamado quando a requisição é bem-sucedida
        console.log(data);
        this.listaBestiario = data;
      },
      error: error => {   // O error é chamado quando a requisição falha
        console.error(error);
      }
    });
  }

  // #endregion Methods

}

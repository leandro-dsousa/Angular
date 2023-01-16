import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-card-display',
  templateUrl: './card-display.component.html',
  styleUrls: ['./card-display.component.css']
})

export class CardDisplayComponent implements OnInit {
 
  @Input() image = '';

  modal = document.querySelector("#modal");

  constructor() { }

  ngOnInit(): void {
  }

  expandCardOnClick(): void {
    (this.modal as HTMLDialogElement).showModal();
  }
}

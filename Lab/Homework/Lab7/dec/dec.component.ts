import {Component, OnInit, OnDestroy, OnChanges, SimpleChanges} from '@angular/core';
import { CommonModule } from '@angular/common';
import {MatCardModule} from '@angular/material/card';
import {MatIconModule} from '@angular/material/icon';
import {MatDividerModule} from '@angular/material/divider';
import {MatButtonModule} from '@angular/material/button';

@Component({
  selector: 'app-dec',
  standalone: true,
    imports: [CommonModule, MatCardModule, MatCardModule, MatDividerModule, MatIconModule, MatButtonModule],
  templateUrl: './dec.component.html',
  styleUrl: './dec.component.scss'
})
export class DecComponent {

  public counter: number = 0;
  public showButtons: boolean = false;

  addToCounter() : void { this.counter++; }
  subToCounter() : void { this.counter--; }
  toShowButtons() : void {this.showButtons = true}

  constructor() {
    let div = document.getElementById('titleContainer');
    console.log("Constructor",div);
  }
  ngOnChanges(changes: SimpleChanges): void { }

  ngOnInit(): void {
    let div = document.getElementById('titleContainer');
    console.log("OnInit",div); }

  ngOnDestroy(): void{ }
}

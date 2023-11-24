import {Component, OnInit, OnDestroy, OnChanges, SimpleChanges} from '@angular/core';
import { CommonModule } from '@angular/common';
import {MatCardModule} from '@angular/material/card';
import {MatIconModule} from '@angular/material/icon';
import {MatDividerModule} from '@angular/material/divider';
import {MatButtonModule} from '@angular/material/button';

@Component({
  selector: 'app-demo',
  standalone: true,
  imports: [CommonModule, MatCardModule, MatCardModule, MatDividerModule, MatIconModule, MatButtonModule],
  templateUrl: './demo.component.html',
  styleUrl: './demo.component.scss'
})
export class DemoComponent implements OnInit, OnDestroy, OnChanges{

  public title: string = "Demo title";
  public counter : number = 0;

  addToCounter() : void
  {
    this.counter++;
  }

  subToCounter() : void
  {
    this.counter--;
  }

  constructor() {
    let div = document.getElementById('titleContainer');
    console.log("Constructor",div);
  }
  ngOnChanges(changes: SimpleChanges): void {
  }

  ngOnInit(): void {
    let div = document.getElementById('titleContainer');
    console.log("OnInit",div);
  }

  ngOnDestroy(): void{
  }


}

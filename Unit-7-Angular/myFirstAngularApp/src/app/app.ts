import { CommonModule } from '@angular/common';
import { isNgContainer } from '@angular/compiler';
import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-root',
  imports: [CommonModule],
  templateUrl: './app.html',
  styleUrl: './app.css'
})


export class App {
  protected title = 'myFirstAngularApp';

  gridItems = [
    { name: 'Item 1', icon: 'assets/bull.png'},
    { name: 'Item 2', icon: 'assets/log.png'},
    { name: 'Item 3', icon: 'assets/wheat.png'},
    { name: 'Item 4', icon: 'assets/home.png'},
    { name: 'Item 5', icon: 'assets/water-well.png'},
    { name: 'Item 6'},
    { name: 'Item 7'},
    { name: 'Item 8'},
    { name: 'Item 9'},
    { name: 'Item 10'},
    { name: 'Item 11'},
    { name: 'Item 12'},
    { name: 'Item 13'},
    { name: 'Item 14'},
    { name: 'Item 15'},
    { name: 'Item 16'},
    { name: 'Item 17'},
    { name: 'Item 18'},
    { name: 'Item 19'},
    { name: 'Item 20'},
    { name: 'Item 21'},
    { name: 'Item 22'},
    { name: 'Item 23'},
    { name: 'Item 24'},
    { name: 'Item 25'}
  ];

  onGridItemClick(item: any) {
    console.log('Grid item clicked:', item.name);
  }
}

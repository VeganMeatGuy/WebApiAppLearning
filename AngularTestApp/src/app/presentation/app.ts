import { Component, signal, OnInit } from '@angular/core';
import { RouterModule, RouterOutlet } from '@angular/router';
import { NgbDropdownModule } from '@ng-bootstrap/ng-bootstrap';


@Component({
  selector: 'app-root',
  imports: [RouterModule, RouterOutlet ,NgbDropdownModule],
  templateUrl: './app.html'
})
export class App implements OnInit {
  protected readonly title = signal('Hofkammer');

  ngOnInit() {
		
  }
}


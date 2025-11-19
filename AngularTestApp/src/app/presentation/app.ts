import { Component, signal, OnInit, inject } from '@angular/core';
import { RouterModule, RouterOutlet } from '@angular/router';
import { NgbDropdownModule } from '@ng-bootstrap/ng-bootstrap';
import { AppStore } from '../application/app.store';


@Component({
  selector: 'app-root',
  imports: [RouterModule, RouterOutlet ,NgbDropdownModule],
  templateUrl: './app.html',
})
export class App implements OnInit {
  protected readonly title = signal('Hofkammer');
  private appStore = inject(AppStore);

  async ngOnInit() {
		await this.appStore.init();
  }
}


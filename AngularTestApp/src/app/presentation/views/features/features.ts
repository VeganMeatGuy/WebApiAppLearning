import { Component, OnInit, inject} from '@angular/core';
import { AppStore } from '../../../application/app.store';

@Component({
  selector: 'app-features',
  imports: [],
  templateUrl: './features.html',
  styleUrl: './features.scss',
})

export class Features implements OnInit {
  private appStore = inject(AppStore);
  counter = this.appStore.counter;
  textest = this.appStore.test123;

	ngOnInit(): void {
    	}

  	async addOne() {
        this.appStore.addOne(this.appStore.counter());
		}
	}


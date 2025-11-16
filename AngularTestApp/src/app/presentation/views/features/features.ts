import { Component,OnInit} from '@angular/core';
import { FormControl} from '@angular/forms';
import { NgClass } from '@angular/common';

@Component({
  selector: 'app-features',
  imports: [],
  templateUrl: './features.html',
  styleUrl: './features.scss',
})

export class Features implements OnInit {

  counterValue = 0;
  counterText = this.counterValue.toString

	ngOnInit(): void {
    this.counterValue = 1
    	}

  	async addOne() {
        this.counterValue = this.counterValue + 1;
		}
	}


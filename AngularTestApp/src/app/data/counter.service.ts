import { Injectable } from '@angular/core';
import { Counter } from '../models/counter.model';

@Injectable({
	providedIn: 'root',
 })

export class CounterService {
    getCounter(): Counter {
        return new Counter();
    }

    addOneToCounter(counter: Counter){
        counter.value = counter.value + 1;
        return counter;
    }
}
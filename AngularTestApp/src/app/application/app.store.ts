import { inject} from '@angular/core';
import { patchState, signalStore, withMethods, withState } from '@ngrx/signals';
import { Counter } from '../models/counter.model';
import { CounterService } from '../data/counter.service';

type AppState = {
	counter: Counter | undefined;
    test123: string;
};

const initialState: AppState = {
	counter: undefined,
    test123: ""
};

export const AppStore = signalStore(
	{ providedIn: 'root' },
	withState(initialState),
	withMethods(
		(
			store,
            counterService = inject(CounterService)
		) => ({
			init(): void {
                const counter3 = counterService.getCounter();
                patchState(store, {counter: counter3, test123: "init geschafft"});
			},
			addOne(counter: Counter | undefined): void {
                if (counter === undefined)
                {}
                else 
                {
                    const counterResult = counterService.addOneToCounter(counter);
				    patchState(store, {counter: counterResult, test123: "geht"});
                }
				}
		})
	)
);
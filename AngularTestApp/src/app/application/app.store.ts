import { inject } from '@angular/core';
import { patchState, signalStore, withMethods, withState } from '@ngrx/signals';
import { Counter } from '../models/counter.model';
import { CounterService } from '../data/counter.service';
import { Observable } from 'rxjs';

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
			async init(): Promise<void> {
				const counter3 = await counterService.getCounter();
				patchState(store, { counter: counter3, test123: "init geschafft" });
			},

			async addOne(counter: Counter | undefined): Promise<void> {
				if (counter === undefined) { }
				else {
					const counterResult = await counterService.addOneToCounter(counter);
					patchState(store, { counter: counterResult, test123: "geht hoch" });
				}
			},

			async removeOne(counter: Counter | undefined): Promise<void> {
				if (counter === undefined) { }
				else {
					const counterResult = await counterService.removeOneFromCounter(counter);
					patchState(store, { counter: counterResult, test123: "geht auch runter" });
				}
			}
		})
	)
);
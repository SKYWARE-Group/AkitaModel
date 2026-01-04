# Akita Model TypeScript

TypeScript models for the Akita LIS iLab API.

This package provides TypeScript type definitions and classes for interacting with the Akita Laboratory Information System (LIS) API.

## Installation

```bash
npm install skyware.lis.akitamotel
```

## Usage

### Import all models

```typescript
import * as AkitaModel from 'skyware.lis.akitamotel';

const patient = new AkitaModel.Patient();
patient.givenName = 'John';
patient.familyName = 'Doe';
```

### Import specific namespaces

```typescript
import { Patient, Doctor, Sale } from 'skyware.lis.akitamotel';
import { Portal, Results, BgNhis } from 'skyware.lis.akitamotel';

const patient = new Patient();
const visit = new Portal.Visit();
const results = new Results.VisitResults();
```

### Import from sub-namespaces

```typescript
import { CalculationResult, ResultRequest } from 'skyware.lis.akitamotel/Flagging';
import { Heartbeat } from 'skyware.lis.akitamotel/Heartbeats';
```

## Package Structure

The package is organized to match the C# namespace structure:

- **Root namespace (`Skyware.Lis.AkitaModel`)**: Core models like Patient, Doctor, Sale, etc.
- **BgNhis**: Bulgaria NHIS/NHIF-specific models
- **Courier**: Communication channel models
- **Flagging**: Result flagging and calculation models
- **Heartbeats**: Application heartbeat models
- **Helpers**: Utility classes for JSON, Base64, and date handling
- **Portal**: Patient portal-specific models
- **Results**: Laboratory results and reporting models
- **Robin**: Report generation models
- **SmartScan**: Document scanning and upload models

## Key Models

### Patient Management
- `Patient`: Patient demographic information
- `Doctor`: Healthcare provider information
- `PersonBase`: Abstract base class for people

### Laboratory Orders & Results
- `Sale`: Laboratory order/visit
- `SaleItem`: Individual test or panel in an order
- `Test`: Laboratory test (analyte) definition
- `Profile`: Panel/profile of tests
- `Sample`: Laboratory sample

### Results & Reporting
- `Results.VisitResults`: Complete visit results for reporting
- `Results.VisitBalance`: Visit balance and billing information
- `Portal.Visit`: Patient portal visit summary
- `Portal.TestHistory`: Historical test results for a patient

### Reference Data
- `Department`: Laboratory department
- `Species`: Patient species (human, veterinary)
- `SampleType`: Type of laboratory sample
- `ReferenceRange`: Test reference ranges by age and gender
- `FlagLevels`: Result flag levels (normal, high, low, etc.)

## TypeScript-Specific Notes

### Enum Handling
Enums are preserved as TypeScript enums:

```typescript
import { FlagLevels, PaymentMethod, ResultTypes } from 'skyware.lis.akitamotel';

const flag: FlagLevels = FlagLevels.HIGH;
const payment: PaymentMethod = PaymentMethod.Card;
const type: ResultTypes = ResultTypes.Quantitative;
```

### Abstract Classes
Abstract classes use TypeScript's abstract keyword:

```typescript
import { PersonBase, PaymentBase } from 'skyware.lis.akitamotel';

// Cannot instantiate abstract classes directly
// const person = new PersonBase(); // Error!

class CustomPerson extends PersonBase {
  // Must implement abstract members
}
```

### Date Handling
C# DateTime properties are represented as JavaScript Date:

```typescript
const patient = new Patient();
patient.dateOfBirth = new Date('1990-01-15');

const sale = new Sale();
sale.registered = new Date();
```

### Nullable Types
Optional properties use TypeScript's optional syntax (`?:`):

```typescript
interface Example {
  id?: number;        // Optional/nullable
  name: string;       // Required
  value?: string;     // Optional/nullable
}
```

### Collections
C# collections are represented as TypeScript arrays:

```typescript
const sale = new Sale();
sale.items = []; // IList<SaleItem> becomes SaleItem[]
sale.samples = []; // IList<Sample> becomes Sample[]
```

## Constants

Access API endpoint constants:

```typescript
import { Constants } from 'skyware.lis.akitamotel';

const testsUrl = Constants.URL_CORE_PUBLIC_TESTS;
const salesUrl = Constants.URL_CORE_SALES;
```

## Documentation

All classes, properties, and methods include JSDoc comments transferred from the original C# XML documentation:

```typescript
/**
 * Patient.
 */
export class Patient extends PersonBase {
  /**
   * Date of birth.
   */
  dateOfBirth?: Date;
  
  /**
   * Gender indicator.
   */
  isMale?: boolean;
}
```

## License

ISC

## Repository

https://github.com/SKYWARE-Group/AkitaModel

## Author

Mikhail Kalatchev

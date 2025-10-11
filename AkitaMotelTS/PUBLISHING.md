# Publishing Guide for skyware.lis.akitamotel

This guide will help you publish the TypeScript package to npm.

## Pre-Publishing Checklist

✅ **Build Successful**: TypeScript compilation completed without errors
✅ **Type Definitions Generated**: `.d.ts` files created in `dist/` folder
✅ **Source Maps Created**: `.d.ts.map` and `.js.map` files for debugging
✅ **Package.json Configured**: All required fields set
✅ **README.md Created**: Comprehensive documentation
✅ **LICENSE.txt Included**: ISC license file copied
✅ **.npmignore Created**: Source files excluded from package

## Package Structure

```
dist/               # Compiled JavaScript + type definitions
src/                # TypeScript source (excluded from npm)
README.md           # Package documentation
LICENSE.txt         # ISC license
package.json        # Package metadata
```

## Publishing Steps

### 1. Login to npm (first time only)

```bash
npm login
```

Enter your npm credentials when prompted.

### 2. Verify Package Contents

Before publishing, check what files will be included:

```bash
npm pack --dry-run
```

This shows the exact files that will be published.

### 3. Test the Package Locally (Optional)

Create a test project and install your package locally:

```bash
# In another directory
mkdir test-akita-model
cd test-akita-model
npm init -y
npm install ../path/to/AkitaMotelTS
```

Test importing the models:

```typescript
import { Patient, Doctor } from 'skyware.lis.akitamotel';
```

### 4. Bump Version (if needed)

For subsequent releases:

```bash
# Patch version (1.0.0 -> 1.0.1)
npm version patch

# Minor version (1.0.0 -> 1.1.0)
npm version minor

# Major version (1.0.0 -> 2.0.0)
npm version major
```

### 5. Publish to npm

```bash
npm publish
```

If this is a scoped package for your organization:

```bash
npm publish --access public
```

## Post-Publishing

### Verify Publication

Check that your package is available:

```bash
npm view skyware.lis.akitamotel
```

Or visit: https://www.npmjs.com/package/skyware.lis.akitamotel

### Install from npm

Test installing from npm registry:

```bash
npm install skyware.lis.akitamotel
```

## Usage After Publishing

Users can install your package:

```bash
npm install skyware.lis.akitamotel
```

And use it in their projects:

```typescript
import { Patient, Doctor, Sale } from 'skyware.lis.akitamotel';
import { Portal } from 'skyware.lis.akitamotel';

const patient = new Patient();
patient.givenName = 'John';

const visit = new Portal.Visit();
```

## Troubleshooting

### Package Name Already Taken

If `skyware.lis.akitamotel` is already taken, you can:

1. Use a scoped package: `@skyware/akitamotel`
2. Choose a different name: `akita-lis-model`

Update `package.json`:

```json
{
  "name": "@skyware/akitamotel"
}
```

Then publish with:

```bash
npm publish --access public
```

### Build Errors

If you get build errors, clean and rebuild:

```bash
npm run clean
npm run build
```

### Permission Issues

If you get permission errors, ensure you're logged in:

```bash
npm whoami
```

## Version History

- **1.0.0** - Initial release with complete C# model conversion

## Scripts Reference

- `npm run build` - Compile TypeScript to JavaScript
- `npm run clean` - Remove dist folder
- `npm run lint` - Run ESLint on source files
- `npm run prepublishOnly` - Auto-runs before publishing (clean + build)

## Support

- GitHub: https://github.com/SKYWARE-Group/AkitaModel
- Issues: https://github.com/SKYWARE-Group/AkitaModel/issues
